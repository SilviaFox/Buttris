using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ActiveControllers))]
public class InputScript : MonoBehaviour
{
    public static InputScript instance;


    public enum InputDevice {
        Keyboard,
        Controller
    }

    public static InputMaster input;
    GameManager gameManager;
    CountdownTimer countdownTimer;
    bool initiatedInput;

    public static InputDevice inputDevice;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        input.Gameplay.Disable();
        input.Menu.Disable();
        input.GameTypeMenu.Disable();

        switch (scene.name)
        {
            case "Start":
                input.Menu.Enable();
            break;
            case "MainMenu":
                input.Menu.Enable();
            break;
            case "GameTypes":
                input.GameTypeMenu.Enable();
            break;
        }
    }
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            input = new InputMaster();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else 
            Destroy(this.gameObject);

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(this.gameObject);

        
        //Movement
        #region Game
            input.Gameplay.Left.started += ctx => {if(!GameManager.currentBlock.isHardDropping) GameManager.currentBlock.StartMove("left");};
            input.Gameplay.Right.started += ctx => {if(!GameManager.currentBlock.isHardDropping) GameManager.currentBlock.StartMove("right");};

            input.Gameplay.Left.canceled += ctx => GameManager.currentBlock.StopMove("left");
            input.Gameplay.Right.canceled += ctx => GameManager.currentBlock.StopMove("right");

            //Rotation
            input.Gameplay.RotateL.started += ctx => {if (!GameManager.currentBlock.isHardDropping) GameManager.currentBlock.RotateLeft();};
            input.Gameplay.RotateR.started += ctx => {if(!GameManager.currentBlock.isHardDropping) GameManager.currentBlock.RotateRight();};
            //Dropping
            input.Gameplay.FastDrop.started += ctx => {GameManager.currentBlock.isFastDropping = true;};
            input.Gameplay.FastDrop.canceled += ctx => GameManager.currentBlock.isFastDropping = false;
            // Hard Drop
            if (GameSettings.allowHardDrop)
                input.Gameplay.HardDrop.started += ctx => 
                {if(!GameManager.currentBlock.isHardDropping)
                    {
                        GameManager.currentBlock.isHardDropping = true;
                        AudioManager.instance.Play("Hard Drop Start");
                    }
                };

            
            input.Gameplay.Hold.started += ctx => {if(GameManager.allowHold && GameSettings.allowHold) GameManager.currentBlock.Hold();};
            input.Gameplay.Pause.started += ctx => {gameManager.Pause();};
        #endregion

        #region GameTypeMenu
            input.GameTypeMenu.Down.started += ctx => {GameTypeEditor.current.selectedArea ++; GameTypeEditor.current.UpdateSelection();};
            input.GameTypeMenu.Up.started += ctx => {GameTypeEditor.current.selectedArea --; GameTypeEditor.current.UpdateSelection();};
            input.GameTypeMenu.Right.started += ctx => 
            {if (GameTypeEditor.current.selectedArea != GameTypeEditor.current.selections.Length - 1)
                GameTypeEditor.current.selections[GameTypeEditor.current.selectedArea].GetComponent<GameTypeSelectableInfo>().SelectionRight();
                GameTypeEditor.current.CheckForSwaps();};
            input.GameTypeMenu.Left.started += ctx => 
            {if (GameTypeEditor.current.selectedArea != GameTypeEditor.current.selections.Length - 1)
                GameTypeEditor.current.selections[GameTypeEditor.current.selectedArea].GetComponent<GameTypeSelectableInfo>().SelectionLeft();
                GameTypeEditor.current.CheckForSwaps();};
            input.GameTypeMenu.Start.started += ctx => {if (GameTypeEditor.current.selectedArea == GameTypeEditor.current.selections.Length - 1) GameTypeEditor.current.StartGame();};
        #endregion
        
        input.Menu.TabL.started += ctx => TabGroup.activeTabGroup.ChangeActiveTabL();
        input.Menu.TabR.started += ctx => TabGroup.activeTabGroup.ChangeActiveTabR();
    }
    
    void FixedUpdate()
    {

        if (gameManager != null)
        {
            // Update the current block every frame, unless there is no block to use, in which case, spawn a new one
            if (GameManager.currentBlock != null)
                GameManager.currentBlock.BlockUpdate();
            else if (!GameManager.gameEnded && !GameManager.useHeld)
                FindObjectOfType<GameManager>().SpawnBlock();
        }
        else if (CountdownTimer.startedGame)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
        
    }
}
