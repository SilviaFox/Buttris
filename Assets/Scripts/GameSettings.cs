public class GameSettings
{
    public static bool allowHardDrop = true, allowHold = true, showNext = true, trueRandom = false, enableGhost = true;

    public static float dropTime = 1, lockDelay = 0.5f, fastDropTime = 0.2f;

    public static float dASDelay = 0, dASRepeatSpeed = 0.1f;

    public static bool enableGrid = true;
    public static bool lockRotationSprite = false;

    public static string modeName = "Custom";
    public static string gameTypeName = "Marathon";
    public static int lineClearWinCondition = 1;
    public static int countDownTime = 1;


    public void SetWidthAndHeight(int width, int height, bool grid)
    {
        GameManager.width = width ;
        GameManager.height = height + 2; // Add 2 for the buffer zone
        enableGrid = grid;
    }

    public void SetLevel(int level)
    {
        GameManager.values.level = level;
    }

    public void SetGameplayOptions(bool hardDrop, bool hold, bool newShowNext, bool random, bool ghost)
    {
        allowHardDrop = hardDrop;
        allowHold = hold;
        showNext = newShowNext;
        trueRandom = random;
        enableGhost = ghost;
    }

    // public void SetGameSpeed(float drop, float lockSpeed = 0.1f, float fastDrop = 0)
    // {
    //     dropTime = drop;
    //     lockDelay = lockSpeed;
    //     fastDropTime = fastDrop == 0? dropTime / 20 : fastDrop;
    // }

    public void SetModeName(string name)
    {
        modeName = name;
    }

    public void SetGameType(string name, int value)
    {
        gameTypeName = name;
        switch (gameTypeName)
        {
            case "Ultra":
                countDownTime = value;
            break;

            case "Sprint":
                lineClearWinCondition = value;
            break;

            case "Marathon":
                lineClearWinCondition = value;
            break;
        }
    }
}
