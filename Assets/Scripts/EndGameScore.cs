using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameScore : MonoBehaviour
{
    [SerializeField] Text finalScore;
    [SerializeField] Text linesCleared;
    [SerializeField] Text finalTime;

    [SerializeField] GameObject fadeToBlack;
    

    private void Start()
    {
        finalScore.text = "Score: " + GameManager.values.score.ToString();
        linesCleared.text = "Lines: " + GameManager.values.linesCleared.ToString();
        // Display time
        if (GameManager.values.finalTimeMinutes != 0)
            finalTime.text = "Time: " + GameManager.values.finalTimeMinutes.ToString() + ":" +
            (GameManager.visualTimerSeconds < 10? "0" + GameManager.visualTimerSeconds.ToString() : GameManager.visualTimerSeconds.ToString());
        else // Only display seconds if no minutes are counted
            finalTime.text = "Time: " + GameManager.values.finalTimeSeconds.ToString();

        GameManager.gameEnded = false;
    }

    public void RetryGame()
    {
        Instantiate(fadeToBlack).GetComponent<FadeSceneChange>().sceneToChangeTo = "Game";
    }

    public void ExitGame()
    {
        Instantiate(fadeToBlack).GetComponent<FadeSceneChange>().sceneToChangeTo = "MainMenu";
    }

}
