public class GameSettings
{
    public static int playGroundWidth = 12, playGroundHeight = 20;

    public static bool allowHardDrop = true, allowHold = true, showNext = true, trueRandom = false, enableGhost = true;

    public static float dropTime = 1, fastDropTime = 0.2f;

    public static bool enableGrid = true;

    public static bool countDownTimer = false;
    public static float countDownTime = 60;

    public static string modeName = "Custom";

    public void SetWidthAndHeight(int width, int height, bool grid)
    {
        playGroundWidth = width;
        playGroundHeight = height;
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

    public void SetGameSpeed(float drop, float fastDrop = 0)
    {
        dropTime = drop;
        fastDropTime = fastDrop == 0? dropTime / 20 : fastDrop;
    }

    public void SetModeName(string name)
    {
        modeName = name;
    }
}
