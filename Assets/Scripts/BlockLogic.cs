using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockLogic : MonoBehaviour
{   

    [HideInInspector] public bool isFastDropping;
    [HideInInspector] public bool isHardDropping;
    [HideInInspector] public RotationInformation rotInfo; // Info about rotation and if it is valid
    [HideInInspector] public int intReg;
    float timer = 0f; // Timer that counts for every move


    [SerializeField, Range(1,3), Tooltip(" 1 = Full Rotation \n 2 = 2 Rotations \n 3 = No Rotations")]
    int rotType = 1;
    

    GameManager gameManager;
    
    [SerializeField] GameObject rig; // Rig of the current tetromino
    [SerializeField] GameObject ghost; // Ghost of the current tetromino
    [SerializeField] Sprite holdSprite;
    GameObject currentGhost;
    Transform ghostRig;

    
    void Start()
    {

        rotInfo = new RotationInformation();
        rotInfo.valid = true;
        gameManager = FindObjectOfType<GameManager>();

        if (GameSettings.enableGhost)
        {    
            currentGhost = Instantiate(ghost, new Vector3(transform.position.x, transform.position.y), new Quaternion());
            ghostRig = currentGhost.transform.GetChild(0);
            
            
            UpdateGhost();
        }
    }

    private void OnEnable()
    {
        GameManager.currentBlock = this;
        InputScript.input.Gameplay.Enable();
    }

    void UpdateGhost()
    {
        currentGhost.transform.position = new Vector3(transform.position.x, transform.position.y);
        ghostRig.transform.rotation = rig.transform.rotation;

        while (!CheckGhost())
        {
            currentGhost.transform.position -= new Vector3(0,1);
        }
            
    }

    bool CheckGhost()
    {
        foreach (Transform subBlock in ghostRig) // Go through every block and see if anything is out of bounds
            {
                // Check if blocks are touching one-another
                if (subBlock.position.y > GameManager.height)
                
                    return false;
                else if (Mathf.FloorToInt(subBlock.position.y) == 0)
                    return true;
                else if (gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y - 1)] != null)
                    return true;
            }
        return false;   
    }

    public void BlockUpdate()
    {
        if (!isHardDropping)
        {
            // Update Timer
            timer += Time.fixedDeltaTime;

            // Drop Piece, if fast dropping, then use fast drop timer
            if (timer > (isFastDropping? GameManager.fastDropTime : GameManager.dropTime))
                Drop();
        }

        else{
            Drop();
        }
    }

    void RegisterBlock()
    {
        if (isHardDropping)
        {
            GameManager.audioManager.Play("Hard Drop End");
            GameManager.audioManager.Stop("Hard Drop Start");
        }
        
        GameManager.hUD.ResetHoldIconAnimation();
        GameManager.hUD.UpdateNextIcons(GameManager.pieceQueue.ToArray());

        Destroy(currentGhost);
        InputScript.input.Gameplay.Disable();

        foreach (Transform subBlock in rig.transform)
        {
            if (Mathf.FloorToInt(subBlock.position.y) >= GameManager.height && !GameManager.gameEnded)    
                gameManager.Fail();            
            else if (!GameManager.gameEnded)
                gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] = subBlock;
        }
    }

    bool CheckValid() // Check if move is valid
    {
        foreach (Transform subBlock in rig.transform) // Go through every block and see if anything is out of bounds
        {
            if (subBlock.transform.position.x >= GameManager.width ||
                subBlock.transform.position.x < 0 ||
                subBlock.transform.position.y < 0)

                return false;

            // Check if blocks are touching one-another
            if (subBlock.position.y < GameManager.height && gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] != null)
                return false;
        }
        return true; // Else, it is valid
    }

    void CheckRotation(string rotationType) // Check if rotation is valid
    {
        foreach (Transform subBlock in rig.transform)
        {
            if (subBlock.transform.position.x < 0) // If subblock is going past the left boundary
            {
                rotInfo.xAdjustment = 1;
                rotInfo.valid = false;
                return;
            }
            else if (subBlock.transform.position.x >= GameManager.width) // If subblock is going past the right boundary
            {
                rotInfo.xAdjustment = -1;
                rotInfo.valid = false;
                return;
            } // Check if subblock intersects with any other subblocks
            else if (subBlock.position.y < GameManager.height && 
                    gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] != null)
            { // Check Depending on how it was rotated, move it in a different direction
                switch (rotationType)
                {
                    case "left":
                        rotInfo.xAdjustment = 1;
                    break;

                    case "right":
                        rotInfo.xAdjustment = -1;
                    break;
                }
                rotInfo.valid = false;
                rotInfo.yAdjustment = 1;
                return;
            }

            if (subBlock.transform.position.y < 0) // if underneath the playspace
            {
                rotInfo.yAdjustment = 1;
                rotInfo.valid = false;
                return;
            }

            rotInfo.valid = true;
        }

    }


    public void Drop()
    {
        if (isFastDropping)
            GameManager.hUD.AddToScore(1);
        else if (isHardDropping)
            GameManager.hUD.AddToScore(2);
        


        transform.position -= new Vector3(0,1);

        if (!CheckValid() && rotInfo.valid)
        {
            transform.position += new Vector3(0,1); // if move is invalid, place the block
            RegisterBlock();
            GameManager.currentBlock = null;
            gameManager.ClearLines();
        }

        timer = 0; // Reset timer every move
    }

    // Hold
    public void Hold()
    {
        if (!GameManager.setHold) // Initial hold
            GameManager.currentBlock = null;
        else // All proceeding holds
            GameManager.useHeld = true;
        
        GameManager.hUD.UpdateHoldIcon(holdSprite);
        gameManager.SwapHeldBlock(intReg);
        Destroy(this.gameObject);
        Destroy(currentGhost);
    }

    // Move Left
    public void MoveLeft()
    {

        transform.position -= new Vector3(1,0);

        if (!CheckValid())
            transform.position += new Vector3(1,0);
        
        if (GameSettings.enableGhost)
            UpdateGhost();
    }

    // Move Right
    public void MoveRight()
    {
        transform.position += new Vector3(1,0);

        if (!CheckValid())
            transform.position -= new Vector3(1,0);
        
        if (GameSettings.enableGhost)
            UpdateGhost();
    }

    public void RotateLeft()
    {
        

        switch (rotType)
        {
            case 1:
                rig.transform.eulerAngles -= new Vector3(0,0,90);

                CheckRotation("left");

                while (!rotInfo.valid)
                {
                    transform.position += new Vector3(rotInfo.xAdjustment, rotInfo.yAdjustment);
                    CheckRotation("left");
                }
            break;
            default:
                rotInfo.valid = true;
            break;
        }

        if (GameSettings.enableGhost)
            UpdateGhost();
        
    }

    public void RotateRight()
    {
        switch (rotType)
        {
            case 1:
                rig.transform.eulerAngles += new Vector3(0,0,90);
                CheckRotation("right");
                while (!rotInfo.valid)
                {
                    transform.position += new Vector3(rotInfo.xAdjustment, rotInfo.yAdjustment);
                    CheckRotation("right");
                }
            break;

            default:
                rotInfo.valid = true;
            break;
        }

        if (GameSettings.enableGhost)
            UpdateGhost();
    }
}
