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
    bool isLockChecking;
    bool movedDuringCheck;

    GameManager gameManager;
    
    [SerializeField] GameObject rig; // Rig of the current tetromino
    [SerializeField] GameObject ghost; // Ghost of the current tetromino
    [SerializeField] Sprite holdSprite;
    GameObject currentGhost;
    Transform ghostRig;

    // 0 = spawn state
    // R = state resulting from a clockwise rotation ("right") from spawn
    // L = state resulting from a counter-clockwise ("left") rotation from spawn
    // 2 = state resulting from 2 successive rotations in either direction from spawn.
    string rotationState = "0";
    Vector2[] wallKickTests = new Vector2[5];
    Vector2 rotationPosition;
    [SerializeField] bool iPiece;

    // DAS
    Coroutine dASInstance = null;
    string moveDirection;

    
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

        foreach (Transform subBlock in rig.transform)
        {
            subBlock.gameObject.GetComponent<SpriteRenderer>().sprite = CustomizableOptions.blockSkin;
        }
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
            timer += Time.deltaTime;

            // Drop Piece, if fast dropping, then use fast drop timer
            
            if (!isLockChecking && timer > (isFastDropping? GameManager.fastDropTime : GameManager.dropTime))
                Drop();
            else if (isLockChecking && !isFastDropping && timer > GameManager.dropTime + (movedDuringCheck? GameSettings.lockDelay : 0))
                {
                // Drop();
                TryLock();}
            else if (isLockChecking && isFastDropping && timer > GameManager.fastDropTime)
                {
                // Drop();
                TryLock();}
        }

        else{
            if (!isLockChecking)
                Drop();
            else{
                Drop();
                if (!CheckValid())
                { 
                    transform.position += new Vector3(0,1);
                    RegisterBlock();
                }
            }
        }
    }

    void TryLock()
    {
        Drop();
        if (!CheckValid())
        {
            transform.position += new Vector3(0,1);
            RegisterBlock();
        }
    }

    void RegisterBlock()
    {
        if (dASInstance != null)
            StopCoroutine(dASInstance);

        if (isHardDropping)
        {
            AudioManager.instance.Play("Hard Drop End");
            StartCoroutine(GameManager.cameraMovement.CameraShake(0.1f, 0.2f));
            // AudioManager.instance.Stop("Hard Drop Start");
        }
        else
            AudioManager.instance.Play("Landing");
        
        if (GameSettings.showNext)
            GameManager.hUD.UpdateNextIcons(GameManager.pieceQueue.ToArray());
        GameManager.useHeld = false;

        Destroy(currentGhost);
        InputScript.input.Gameplay.Disable();

        foreach (Transform subBlock in rig.transform)
        {
            if (Mathf.FloorToInt(subBlock.position.y) >= GameManager.height && !GameManager.gameEnded)    
                gameManager.Fail(); 
            else if(gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] != null)
                gameManager.Fail();           
            else if (!GameManager.gameEnded)
                gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] = subBlock;
        }

        GameManager.currentBlock = null;
        gameManager.ClearLines();
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
        {
            GameManager.hUD.AddToScore(1);
            AudioManager.instance.Play("Soft Drop");
        }
        else if (isHardDropping)
            GameManager.hUD.AddToScore(2);

        transform.position -= new Vector3(0,1);

        if (!isLockChecking && !CheckValid())
        {
            transform.position += new Vector3(0,1); // if move is invalid, place the block
            isLockChecking = true;
        }
        else
        {
            isLockChecking = false;
            movedDuringCheck = false;
        }

        timer = 0; // Reset timer every move
    }

    public void Hold()
    {
        if (dASInstance != null)
            StopCoroutine(dASInstance);
        AudioManager.instance.Play("Hold");

        if (!GameManager.setHold) // Initial hold
            {
                GameManager.currentBlock = null;
                GameManager.SetHeldBlock(intReg);
                if (GameSettings.showNext)
                    GameManager.hUD.UpdateNextIcons(GameManager.pieceQueue.ToArray());
            }
        else // All proceeding holds
        {
            GameManager.useHeld = true;
            gameManager.SwapHeldBlock(intReg);
        }
        GameManager.hUD.UpdateHoldIcon(holdSprite);
        Destroy(this.gameObject);
        Destroy(currentGhost);
        
    }

    bool SuperRotationSystem(string rotationDirection)
    {
        bool invalidRotation = false;
        
        for (int i = 0; i < wallKickTests.Length; i++)
        {
            // Test a new position
            invalidRotation = false;

            // Add offset for testing
            transform.position += (Vector3)wallKickTests[i];

            // check sub blocks for invalidity
            foreach (Transform subBlock in rig.transform)
            {
                // initially check position in relation to the playground, to avoid errors
                if (subBlock.position.x < 0 || subBlock.position.x >= GameManager.width || Mathf.FloorToInt(subBlock.position.y) < 0)
                    invalidRotation = true;
                else if(Mathf.FloorToInt(subBlock.position.y) < GameManager.height && gameManager.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] != null)
                    invalidRotation = true;
                        
            }

            if (invalidRotation)
                transform.position -= (Vector3)wallKickTests[i];
            
            else
                break; // Break out of the for loop if pos is valid
        }

        if (rotationDirection == "right")
            rig.transform.eulerAngles += new Vector3(0,0,90);
        else
            rig.transform.eulerAngles -= new Vector3(0,0,90);

        return !invalidRotation;
        
    }

    public void StartMove(string direction)
    {
        // Stop any running DAS instances
        if (dASInstance != null)
            StopCoroutine(dASInstance);
        
        // Start a new DAS instance
        dASInstance = StartCoroutine(DAS(direction));
    }

    public void StopMove(string direction)
    {
        // allow for quick input switches by checking the direction of the input released
        if (dASInstance != null && direction == moveDirection)
            StopCoroutine(dASInstance);
    }

    public IEnumerator DAS(string direction)
    {
        float delay = GameSettings.dASDelay + Time.time;
        float repeatSpeed = GameSettings.dASRepeatSpeed;
        moveDirection = direction;

        switch (direction)
        {
            case "left":
                MoveLeft();
            break;

            case "right":
                MoveRight();
            break;
        }

        while (delay >= Time.time)
        {
            yield return null;
        }

        yield return new WaitForSecondsRealtime(repeatSpeed);

        while (true)
        {
            switch (direction)
            {
                case "left":
                    MoveLeft();
                break;

                case "right":
                    MoveRight();
                break;
            }
            
            yield return new WaitForSecondsRealtime(repeatSpeed);
        }

        
    }

    public void MoveLeft()
    {

        transform.position -= new Vector3(1,0);

        

        if (isLockChecking)
            movedDuringCheck = true;

        if (!CheckValid())
            transform.position += new Vector3(1,0);
        else
            AudioManager.instance.Play("Move");
        
        
        if (GameSettings.enableGhost)
            UpdateGhost();

    }

    public void MoveRight()
    {

        transform.position += new Vector3(1,0);

        if (isLockChecking)
            movedDuringCheck = true;

        if (!CheckValid())
        
            transform.position -= new Vector3(1,0);
        else
            AudioManager.instance.Play("Move");
        
        if (GameSettings.enableGhost)
            UpdateGhost();
    }

    public void RotateLeft()
    {
        string previousRotation = "";
        
        switch (rotationState)
        {
            case "0":
                previousRotation = "0";
                rotationState = "L";
                wallKickTests = iPiece? SRSWallKickTests.iZeroL : SRSWallKickTests.ZeroL;
            break;

            case "L":
                previousRotation = "L";
                rotationState = "2";
                wallKickTests = iPiece? SRSWallKickTests.iLTwo : SRSWallKickTests.LTwo;
            break;

            case "2":
                previousRotation = "2";
                rotationState = "R";
                wallKickTests = iPiece? SRSWallKickTests.iTwoR : SRSWallKickTests.TwoR;
            break;

            case "R":
                previousRotation = "R";
                rotationState = "0";
                wallKickTests = iPiece? SRSWallKickTests.iRZero : SRSWallKickTests.RZero;
            break;
        }

        rig.transform.eulerAngles += new Vector3(0,0,90);

        // CheckRotation("left");
        // while (!rotInfo.valid)
        // {
        //     transform.position += new Vector3(rotInfo.xAdjustment, rotInfo.yAdjustment);
        //     CheckRotation("left");
        // }  
        

        if (SuperRotationSystem("left"))
        {
            rig.transform.eulerAngles += new Vector3(0,0,90);
            AudioManager.instance.Play("Rotate");
            // Counter-rotate subblocks
            if (GameSettings.lockRotationSprite)
                foreach (Transform subBlock in rig.transform)
                {
                    subBlock.transform.eulerAngles -= new Vector3(0,0,90);
                }
        }   
        else
            rotationState = previousRotation;


        if (isLockChecking)
            movedDuringCheck = true;

        if (GameSettings.enableGhost)
            UpdateGhost();
        
    }

    public void RotateRight()
    {
        string previousRotation = "";

        switch (rotationState)
        {
            case "0":
                previousRotation = "0";
                rotationState = "R";
                wallKickTests = iPiece? SRSWallKickTests.iZeroR : SRSWallKickTests.ZeroR;
            break;

            case "R":
                previousRotation = "R";
                rotationState = "2";
                wallKickTests = iPiece? SRSWallKickTests.iRTwo : SRSWallKickTests.RTwo;
            break;

            case "2":
                previousRotation = "2";
                rotationState = "L";
                wallKickTests = iPiece? SRSWallKickTests.iTwoL : SRSWallKickTests.TwoL;
            break;

            case "L":
                previousRotation = "L";
                rotationState = "0";
                wallKickTests = iPiece? SRSWallKickTests.iLZero : SRSWallKickTests.LZero;
            break;
        }
        
        rig.transform.eulerAngles -= new Vector3(0,0,90);

        // CheckRotation("right");
        // while (!rotInfo.valid)
        // {
        //      transform.position += new Vector3(rotInfo.xAdjustment, rotInfo.yAdjustment);
        //      CheckRotation("right");
        // }

        if (SuperRotationSystem("right"))
        {
            rig.transform.eulerAngles -= new Vector3(0,0,90);
            AudioManager.instance.Play("Rotate");
            // Counter-rotate subblocks
            if (GameSettings.lockRotationSprite)
                foreach (Transform subBlock in rig.transform)
                {
                    subBlock.transform.eulerAngles += new Vector3(0,0,90);
                }
        }   
        else
            rotationState = previousRotation;

        
        if (isLockChecking)
            movedDuringCheck = true;

        if (GameSettings.enableGhost)
            UpdateGhost();
    }
}
