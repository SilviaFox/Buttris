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
        Time.timeScale = 1;
        Destroy(this.gameObject);
        Instantiate(fadeSceneChange).GetComponent<FadeSceneChange>().sceneToChangeTo = "MainMenu";
    }
}
