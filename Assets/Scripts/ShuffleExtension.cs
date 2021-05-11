using System.Collections.Generic;
using UnityEngine;

public static class ShuffleExtension
{
    // Shuffle Arrays:
    // Shuffle<T> means we can use any array for this
    // Shuffle accuracy is the amount of times we shuffle it
    public static void Shuffle<T>(this T[] array, int shuffleAccuracy)
    {
        for (int i = 0; i < shuffleAccuracy; i++)
        {
            int randomIndex = Random.Range (1, array.Length);

            T temp = array[randomIndex];
            array[randomIndex] = array[0];
            array[0] = temp;
        }
    }
}
