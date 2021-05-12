using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject[] tetrominos; // List of pieces

    [SerializeField] GameObject deathScreen;
    [SerializeField] GameObject pauseScreen;
    public static GameObject currentPauseScreen;

    // These get set by Custom Settings
    public static int width = 12, height = 20;
    public static float dropTime;
    public static float fastDropTime;

    bool enableTimer;
    float timer;
    public static int visualTimerSeconds, visualTimerMinutes;

    // Spawn point is halfway on the board, 1.5 units above height
    public static Vector3 spawnPoint;

    int[] sevenBag = new int[7] {0,1,2,3,4,5,6};
    public static Queue<int> pieceQueue;

    // Current Block
    public static BlockLogic currentBlock;
    public static AudioManager audioManager;

    public static bool gameEnded; // If true, the game has ended

    public static bool allowHold = true; // If false, player cannot hold
    public static bool useHeld; // If true, use the currently held block
    public static bool setHold; // If hold has been set before
    public static int heldBlock; // Current held block

    bool bTBTetris; // Able to do a back-to-back Tetris

    public Transform[,] grid = new Transform[width, height];

    public static GameValues values = new GameValues();
    public static GameHUD hUD;

    


    private void Awake()
    {
        ResetTimer();

        dropTime = GameSettings.dropTime;
        fastDropTime = GameSettings.fastDropTime;

        audioManager = FindObjectOfType<AudioManager>();
        hUD = FindObjectOfType<GameHUD>();

        // Initialize the piece queue.
        pieceQueue = new Queue<int>();

        SevenBagGenerator();
    }

    void Update()
    {
        if (enableTimer)
            Timer();
    }

    void Timer()
    {
        timer += Time.deltaTime;
        visualTimerSeconds = Mathf.FloorToInt(timer);

        if (visualTimerSeconds == 60)
        {
            timer = 0;
            visualTimerSeconds = 0;
            visualTimerMinutes += 1;
        }
    }

    void ResetTimer()
    {
        enableTimer = true;
        timer = 0;
        visualTimerSeconds = 0;
        visualTimerMinutes = 0;
    }

    void SevenBagGenerator()
    {
        sevenBag.Shuffle(6);

        // Make sure the maximum gap between 2 I minos is 12
        for (int i = 5; i < sevenBag.Length; i++)
        {
            if (sevenBag[i] == 0)
            {
                int iReplace = Random.Range(0,6);
                int newPiece = sevenBag[iReplace];

                sevenBag[i] = newPiece;
                sevenBag[iReplace] = 0;

                break;
            }

        }


        // Queue pieces
        for (int i = 0; i < sevenBag.Length; i++)
        {
            pieceQueue.Enqueue(sevenBag[i]);
        }
        
    }

    public void Fail()
    {
        gameEnded = true;
        InputScript.input.Gameplay.Disable();
        enableTimer = false;
        Debug.Log("Game Over");

        values.finalTimeSeconds = visualTimerSeconds;
        values.finalTimeMinutes = visualTimerMinutes;

        Instantiate(deathScreen);
    }

    // Set the first held block
    public static void SetHeldBlock(int block)
    {
        heldBlock = block;
        setHold = true;   
        allowHold = false;
    }

    // Replace block with the current held block
    public void SwapHeldBlock(int block)
    {
        int newHeldBlock = block;
        Instantiate(tetrominos[heldBlock], spawnPoint, new Quaternion()).GetComponent<BlockLogic>().intReg = heldBlock;

        heldBlock = newHeldBlock;
        
        allowHold = false;
    }

    public void ClearLines()
    {
        int clearedLines = 0;
        for (int y = 0; y < height; y++) // Check the Y axis
        {
            while (IsLineComplete(y))
            {
                DestroyLine(y);
                MoveLines(y);
                clearedLines ++;
            }
        }
 
        ScoreFromLines(clearedLines); 
    }

    void ScoreFromLines(int clearedLines)
    {

        int scoreToAdd = 0;

        switch (clearedLines)
        {
            case 1:
                scoreToAdd += (100 * values.level);
                audioManager.Play("Single");
                bTBTetris = false;
            break;
            case 2:
                scoreToAdd += (300 * values.level);
                audioManager.Play("Double");
                bTBTetris = false;
            break;
            case 3:
                scoreToAdd += (500 * values.level);
                audioManager.Play("Triple");
                bTBTetris = false;
            break;
            case 4:
                if (!bTBTetris)
                    {
                        scoreToAdd += (800 * values.level);
                        bTBTetris = true;
                    }
                else
                    scoreToAdd += (800 * 3/2 * values.level);
                audioManager.Play("Tetris");
            break;
        }

        hUD.AddToScore(scoreToAdd);

        values.linesCleared += clearedLines;
        hUD.UpdateLinesCleared();
    }

    void MoveLines(int y)
    {
        for (int i = y; i < height - 1; i++) // go through all lines above the destoyed lines
        {
            for (int x = 0; x < width; x++)
            {
                if (grid[x,i + 1] != null)
                {
                    grid[x,i] = grid[x,i + 1];
                    grid[x,i + 1].gameObject.transform.position -= new Vector3(0,1);
                    grid[x,i + 1] = null;
                }
            }
        }
    }

    void DestroyLine(int y)
    {

        for (int x = 0; x < width; x++) // Go through all blocks on this height and delete them
        {
            Destroy(grid[x,y].gameObject);
            grid[x,y] = null;
        }
    }

    
    bool IsLineComplete(int y)
    {
        for (int x = 0; x < width; x++)
        {
            // if line is not completed
            if (grid[x,y] == null)
            {
                return false; // Return false
            }
        }
        return true; // else, return true
    }

    public void SpawnBlock()
    {
        allowHold = true; // Reenable ability to hold pieces

        int intForBlock = 0;

        
        if (GameSettings.trueRandom) // if using true random
            intForBlock = Random.Range(0,tetrominos.Length);
        else
            intForBlock = pieceQueue.Dequeue();

        Instantiate(tetrominos[intForBlock], spawnPoint, new Quaternion()).GetComponent<BlockLogic>().intReg = intForBlock;

        if (pieceQueue.Count < 7)
            SevenBagGenerator();
        
    }

    public void Pause()
    {
        audioManager.Play("Pause");
        currentPauseScreen = Instantiate(pauseScreen);
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        Destroy(currentPauseScreen);
        currentPauseScreen = null;
    }
}
