using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
    public static Transitions instance;
    [SerializeField] GameObject transition;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public IEnumerator TransitionToNextScene(float speed, string scene)
    {
        transition.SetActive(true);
        Image transitionImage = transform.GetChild(0).GetComponent<Image>();

        for (float i = 0; i < 1.5f; i += speed)
        {
            transitionImage.material.SetFloat("_TransitionTime", i);
            yield return new WaitForFixedUpdate();
        }

        SceneManager.LoadScene(scene);
        StartCoroutine(FinishTransition(speed));
    }

    IEnumerator FinishTransition(float speed)
    {
        Image transitionImage = transform.GetChild(0).GetComponent<Image>();

        for (float i = 1.5f; i >= 0; i -= speed)
        {
            transitionImage.material.SetFloat("_TransitionTime", i);
            yield return new WaitForFixedUpdate();
        }

        transition.SetActive(false);
    }
}
