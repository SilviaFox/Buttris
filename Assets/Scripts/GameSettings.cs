public class GameSettings
{
    public static bool allowHardDrop = true, allowHold = true, showNext = true, trueRandom = false, enableGhost = true;

    public static float dropTime = 1, lockDelay = 0.5f, fastDropTime = 0.2f;

    public static bool enableGrid = true;

    public static bool countDownTimer = false;
    public static float countDownTime = 60;

    public static string modeName = "Custom";

    public void SetWidthAndHeight(int width, int height, bool grid)
    {
        GameManager.width = width;
        GameManager.height = height;
        enableGrid = grid;
    }

    public void SetGameplayType(bool timer, float time)
    {
        countDownTimer = timer;
        countDownTime = time;
    }

    public void SetGameplayOptions(bool hardDrop, bool hold, bool newShowNext, bool random, bool ghost)
    {
        allowHardDrop = hardDrop;
        allowHold = hold;
        showNext = newShowNext;
        trueRandom = random;
        enableGhost = ghost;
    }

    public void SetGameSpeed(float drop, float lockSpeed = 0.1f, float fastDrop = 0)
    {
        dropTime = drop;
        lockDelay = lockSpeed;
        fastDropTime = fastDrop == 0? dropTime / 20 : fastDrop;
    }

    public void SetModeName(string name)
    {
        modeName = name;
    }
}
