using UnityEngine;

public class PresetSettings : MonoBehaviour
{

    public static PresetSettings instance;

    public static GameSettings gameSettings;
    // [SerializeField] GameObject fadeToBlack;
    
    Transform canvas;
    
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
        GetComponent<FadeSceneChange>();
        canvas = FindObjectOfType<Canvas>().gameObject.transform;
        AudioManager.instance = FindObjectOfType<AudioManager>();
    }

    public void SetClassicSettings()
    {
        gameSettings = new GameSettings();
        
        gameSettings.SetWidthAndHeight(10, 24, true);
        gameSettings.SetGameplayOptions(false, false, false, true, false);
        gameSettings.SetModeName("Classic");

        LoadGame();
    }

    public void SetStandardSettings()
    {
        gameSettings = new GameSettings();

        gameSettings.SetWidthAndHeight(10, 20, true);
        gameSettings.SetGameplayOptions(true, true, true, false, true);
        gameSettings.SetModeName("Buttris");

        LoadGame();
    }

    public void LoadGame()
    {
        // GameObject instFade;
        // instFade = Instantiate(fadeToBlack);
        AudioManager.instance.PlayMusic("MainTheme3", AudioManager.instance.currentSongTime);
        StartCoroutine(Transitions.instance.TransitionToNextScene(0.05f, "GameTypes"));
        // instFade.transform.SetParent(canvas);
        // instFade.transform.GetChild(0).gameObject.GetComponent<FadeSceneChange>().sceneToChangeTo = "GameTypes";
    }
}
