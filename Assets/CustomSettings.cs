using System;
using UnityEngine;
using UnityEngine.UI;

public class CustomSettings : MonoBehaviour
{
    [SerializeField] InputField widthField, heightField;

    public void StartCustomGame()
    {
        // Get width and height from input fields
        int width = Int32.Parse(widthField.text);
        int height = Int32.Parse(heightField.text);

        PresetSettings.gameSettings = new GameSettings();

        PresetSettings.gameSettings.SetWidthAndHeight(width,height,true);
        PresetSettings.gameSettings.SetGameplayOptions(true, true, true, false, true);
        PresetSettings.gameSettings.SetModeName("Custom");

        PresetSettings.instance.LoadGame();
    }
}
