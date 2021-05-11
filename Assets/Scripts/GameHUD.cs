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
    

    private void Start()
    {

        if (!GameSettings.allowHold)
        {
            holdIcon.transform.parent.gameObject.SetActive(false);
        }

        holdIconAnimator = holdIcon.gameObject.GetComponent<Animator>();
        UpdateNextIcons(GameManager.pieceQueue.ToArray());
    }

    public void AddToScore(int value)
    {
        GameManager.values.score += value;
        score.text = GameManager.values.score.ToString();
    }

    public void UpdateLinesCleared()
    {
        linesCleared.text = "Lines: " + GameManager.values.linesCleared;
    }

    public void UpdateHoldIcon(Sprite newSprite)
    {
        holdIcon.sprite = newSprite;
        
        holdIconAnimator.Play("HoldSwitch");
    }

    public void UpdateNextIcons(int[] pieces)
    {
        for (int i = 0; i < nextIcons.Length; i++)
        {
            nextIcons[i].sprite = nextIconSprites[pieces[i + 1]];
        }
    }

    public void ResetHoldIconAnimation()
    {
        holdIconAnimator.Play("HoldIdle");
    }
}
