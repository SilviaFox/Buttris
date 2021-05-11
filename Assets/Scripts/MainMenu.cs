using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
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
    }

    void AnimateLogo()
    {
        if (!gameStarted)
        {
            gameStarted = true;
            logo.Play("LogoSelect");
            Instantiate(fadeToBlack).GetComponent<FadeSceneChange>().sceneToChangeTo = scene;
        }
    }
}
