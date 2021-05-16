using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{

    [SerializeField] Text score;
    [Space]
    [SerializeField] Text linesCleared;
    [SerializeField] Image holdIcon;
    Animator holdIconAnimator;
    [Space]
    [SerializeField] Image[] nextIcons;
    [SerializeField] Sprite[] nextIconSprites;
    [Space]
    [SerializeField] Text timer;
    [Space]
    [SerializeField] Text currentLevel;
    Animator nextIconAnimator;
    

    private void Start()
    {

        if (!GameSettings.allowHold)
        {
            holdIcon.transform.parent.gameObject.SetActive(false);
        }

        if (!GameSettings.showNext)
        {
            nextIcons[0].transform.parent.transform.parent.gameObject.SetActive(false);
        }

        nextIconAnimator = nextIcons[0].transform.parent.gameObject.GetComponent<Animator>();
        holdIconAnimator = holdIcon.gameObject.GetComponent<Animator>();
        if (GameSettings.showNext)
            UpdateNextIcons(GameManager.pieceQueue.ToArray());
    }

    void Update()
    {

        if (GameManager.visualTimerMinutes == 0)
            timer.text = GameManager.visualTimerSeconds.ToString();
        else
            timer.text = GameManager.visualTimerMinutes.ToString() + " : " + 
            (GameManager.visualTimerSeconds < 10? "0" + GameManager.visualTimerSeconds.ToString() : GameManager.visualTimerSeconds.ToString());
    }

    public void AddToScore(int value)
    {
        GameManager.values.score += value;
        score.text = GameManager.values.score.ToString();
    }

    public void UpdateLevel(int level)
    {
        currentLevel.text = "Level: " + level.ToString();
    }

    public void UpdateLinesCleared()
    {
        linesCleared.text = "Lines: " + GameManager.values.linesCleared;
    }

    public void UpdateHoldIcon(Sprite newSprite)
    {
        holdIcon.sprite = newSprite;
        
        holdIconAnimator.Play("HoldSwitch", -1, 0);
    }

    public void UpdateNextIcons(int[] pieces)
    {
        
        for (int i = 0; i < nextIcons.Length; i++)
        {
            nextIcons[i].sprite = nextIconSprites[pieces[i + 1]];
        }
        nextIconAnimator.Play("NextIconUpdate", -1, 0);
    }

}
