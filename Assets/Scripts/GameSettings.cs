public class GameSettings
{
    public static int playGroundWidth = 12, playGroundHeight = 20;

    public static bool allowHardDrop = true, allowHold = true, showNext = true, trueRandom = false, enableGhost = true;

    public static float dropTime = 4, fastDropTime = 0.5f;

    public static bool enableGrid = true;

    public static string modeName = "Custom";

    public void SetWidthAndHeight(int width, int height, bool grid)
    {
        playGroundWidth = width;
        playGroundHeight = height;
        enableGrid = grid;
    }

    public void SetGameplayOptions(bool hardDrop, bool hold, bool newShowNext, bool random, bool ghost)
    {
        allowHardDrop = hardDrop;
        allowHold = hold;
        showNext = newShowNext;
        trueRandom = random;
        enableGhost = ghost;
    }

    public void SetGameSpeed(float drop, float fastDrop)
    {
        dropTime = drop;
        fastDropTime = fastDrop;
    }

    public void SetModeName(string name)
    {
        modeName = name;
    }
}
