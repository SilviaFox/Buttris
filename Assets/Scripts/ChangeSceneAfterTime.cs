using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAfterTime : MonoBehaviour
{
    [SerializeField] string scene;
    [SerializeField] float time = 3;

    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("ChangeScene", time);
    }

    // Update is called once per frame
    void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
