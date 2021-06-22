using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] GameObject fadeSceneChange;


    public void Resume()
    {
        Time.timeScale = 1;
        Destroy(this.gameObject);
        InputScript.input.Gameplay.Enable();
    }

    public void Restart()
    {
        Time.timeScale = 1;
        Destroy(this.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        InputScript.input.Gameplay.Disable();
        Time.timeScale = 1;
        Transitions.instance.StartCoroutine(Transitions.instance.TransitionToNextScene(0.05f, "MainMenu"));
        Destroy(this.gameObject);
        // Instantiate(fadeSceneChange).transform.GetChild(0).gameObject.GetComponent<FadeSceneChange>().sceneToChangeTo = "MainMenu";
    }
}
