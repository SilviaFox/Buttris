using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{

    InputMaster input;

    [SerializeField] Animator logo;
    [SerializeField] GameObject fadeToBlack;
    [SerializeField] string scene;
    bool gameStarted;

    private void Start()
    {
        input = new InputMaster();

        input.Menu.Enable();
        input.Menu.Start.started += ctx => AnimateLogo();

        AudioManager.instance = FindObjectOfType<AudioManager>();
    }

    void AnimateLogo()
    {
        if (!gameStarted)
        {
            input.Disable();
            input = null;

            gameStarted = true;
            logo.Play("LogoSelect");
            AudioManager.instance.Play("Pause");
            Instantiate(fadeToBlack).GetComponent<FadeSceneChange>().sceneToChangeTo = scene;
            AudioManager.instance.PlayMusic("MainTheme2", AudioManager.instance.currentSongTime);
        }
    }
}
