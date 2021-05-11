using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeSceneChange : MonoBehaviour
{
    [HideInInspector] public string sceneToChangeTo;

    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }

    private void OnEnable()
    {
        Invoke("ChangeScene", 0.7f);
    }
}
