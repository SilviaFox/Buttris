using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathScreenText : MonoBehaviour
{
    public static TextMeshProUGUI textDisplay;

    void OnEnable()
    {
        textDisplay = GetComponent<TextMeshProUGUI>();
    }

    public static void SetText(string text)
    {
        textDisplay.text = text;
    }
}
