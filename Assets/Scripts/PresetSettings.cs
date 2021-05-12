using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresetSettings : MonoBehaviour
{

    public static GameSettings gameSettings;
    [SerializeField] GameObject fadeToBlack;
    
    Transform canvas;
    
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        GetComponent<FadeSceneChange>();
        canvas = FindObjectOfType<Canvas>().gameObject.transform;
    }

    public void SetClassicSettings()
    {
        gameSettings = new GameSettings();
        
        gameSettings.SetWidthAndHeight(10, 24, true);
        gameSettings.SetGameplayOptions(false, false, false, false, false);
        gameSettings.SetGameSpeed(1);
        gameSettings.SetModeName("Classic");

        LoadGame();
    }

    public void SetStandardSettings()
    {
        gameSettings = new GameSettings();

        gameSettings.SetWidthAndHeight(10, 20, true);
        gameSettings.SetGameplayOptions(true, true, true, false, true);
        gameSettings.SetGameSpeed(0.6f);
        gameSettings.SetModeName("Buttris");

        LoadGame();
    }

    void LoadGame()
    {
        GameObject instFade;
        instFade = Instantiate(fadeToBlack);

        instFade.transform.SetParent(canvas);
        instFade.GetComponent<FadeSceneChange>().sceneToChangeTo = "Game";
    }
}
