using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class FadeSceneChange : MonoBehaviour
{
    [HideInInspector] public string sceneToChangeTo;


    private void OnDestroy()
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }

    void OnEnable()
    {
        transform.localScale = new Vector3(0,0);
        LeanTween.scale(this.gameObject, new Vector3(1,1,1), 0.5f).destroyOnComplete = true;
    }

    
}
