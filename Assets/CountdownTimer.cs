using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static bool startedGame;
    Image countdownPanel;
    [SerializeField] GameObject countdownTime;
    Text timer;

    void OnDisable()
    {
        startedGame = false;
    }

    private void Start()
    {
        countdownPanel = GetComponent<Image>();
        timer = countdownTime.GetComponent<Text>();

        StartCoroutine(CountDown());
    }
    
    public IEnumerator CountDown()
    {
        for (int i = 3; i != 0; i--)
        {
            AudioManager.instance.Play("Count");
            LeanTween.alphaText(timer.rectTransform, 1f, 0f);
            countdownTime.transform.localScale = new Vector3(1,1,1);

            timer.text = i.ToString();
            LeanTween.scale(countdownTime, new Vector3(1.5f, 1.5f, 1.5f), 1f);
            LeanTween.alphaText(timer.rectTransform, 0f, 1f).setEaseInBounce();
            yield return new WaitForSeconds(1);
        }

        AudioManager.instance.Play("GameStart");
        LeanTween.alpha(countdownPanel.rectTransform, 0, 0.2f);
        startedGame = true;
    } 
}
