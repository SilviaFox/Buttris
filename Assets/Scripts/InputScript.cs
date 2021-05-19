using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(ActiveControllers))]
public class InputScript : MonoBehaviour
{
    public enum InputDevice {
        Keyboard,
        Controller
    }

    public static InputMaster input;
    GameManager gameManager;
    bool initiatedInput;

    public static InputDevice inputDevice;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        input = new InputMaster();

        
        //Movement
        input.Gameplay.Left.started += ctx => {if(!GameManager.currentBlock.isHardDropping) GameManager.currentBlock.MoveLeft();};
        input.Gameplay.Right.started += ctx => {if(!GameManager.currentBlock.isHardDropping) GameManager.currentBlock.MoveRight();};
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

        if (GameSettings.allowHold)
            input.Gameplay.Hold.started += ctx => {if(GameManager.allowHold) GameManager.currentBlock.Hold();};
        
        input.Gameplay.Pause.started += ctx => {gameManager.Pause();};
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
        else
        {
            gameManager = FindObjectOfType<GameManager>();
        }
        
    }
}
