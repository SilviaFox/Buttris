using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject[] tetrominoes; // List of pieces

    [SerializeField] GameObject deathScreen;

    // These get set by Custom Settings
    public static int width = 15, height = 30;
    public static float dropTime;
    public static float fastDropTime;

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
        dropTime = GameSettings.dropTime;
        fastDropTime = GameSettings.fastDropTime;

        audioManager = FindObjectOfType<AudioManager>();
        hUD = FindObjectOfType<GameHUD>();

        // Initialize the piece queue.
        pieceQueue = new Queue<int>();

        SevenBagGenerator();
    }

    void SevenBagGenerator()
    {
        sevenBag.Shuffle(6);
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
        Debug.Log("Game Over");

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
        Instantiate(tetrominoes[heldBlock], spawnPoint, new Quaternion()).GetComponent<BlockLogic>().intReg = heldBlock;
        heldBlock = newHeldBlock;

        useHeld = false;
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
                audioManager.Play("ClearLine1");
                bTBTetris = false;
            break;
            case 2:
                scoreToAdd += (300 * values.level);
                audioManager.Play("ClearLine2");
                bTBTetris = false;
            break;
            case 3:
                scoreToAdd += (500 * values.level);
                audioManager.Play("ClearLine3");
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
                audioManager.Play("ClearLine4");
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

        if (!useHeld)
        {
            int intForBlock = 0;

            if (GameSettings.trueRandom) // if using true random
                intForBlock = Random.Range(0,tetrominoes.Length);
            else
                intForBlock = pieceQueue.Dequeue();

            Instantiate(tetrominoes[intForBlock], spawnPoint, new Quaternion()).GetComponent<BlockLogic>().intReg = intForBlock;

            if (pieceQueue.Count < 7)
                SevenBagGenerator();
        }
    }
}
