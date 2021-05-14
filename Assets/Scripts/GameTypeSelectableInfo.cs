using UnityEngine;
using UnityEngine.UI;

public class GameTypeSelectableInfo : MonoBehaviour
{
    Text text;

    // Name of the option
    [SerializeField] string optionName;
    // Options for it
    [SerializeField] string[] options;
    public bool swappableOptions; // if true, options can be changed based on other options
    [SerializeField] string[] secondaryOptions;
    [SerializeField] string[] tertiaryOptions;
    [SerializeField] bool displayZeroZeroAsUnlimited;

    // Options that are rendered in the list
    [HideInInspector] public string[] currentOptions;
    [HideInInspector] public int currentSelection;

    private void Start()
    {
        text = GetComponent<Text>();
        currentOptions = options;
    }

    public void SelectionRight()
    {
        AudioManager.instance.Play("Rotate");
        currentSelection ++;

        if(currentSelection >= currentOptions.Length)
            currentSelection = 0;

        UpdateText();
    }

    public void SelectionLeft()
    {
        AudioManager.instance.Play("Rotate");
        currentSelection --;

        if(currentSelection < 0)
            currentSelection = currentOptions.Length - 1;

        UpdateText();
    }

    public void SwapOptions(int swapTo)
    {
        currentSelection = 0;

        switch (swapTo)
        {
            case 0:
                currentOptions = options;
            break;
            case 1:
                currentOptions = secondaryOptions;
            break;
            case 2:
                currentOptions = tertiaryOptions;
            break;
        }

        UpdateText();
        
    }

    void UpdateText()
    {   
        bool showUnlimited;

        if (displayZeroZeroAsUnlimited && currentSelection == 0 && options == currentOptions)
            showUnlimited = true;
        else
            showUnlimited = false;

        text.text = optionName + ": < " + (showUnlimited? "Unlimited" : currentOptions[currentSelection]) + 
        (currentOptions == tertiaryOptions? " : 00" : "") + " >";
    }
}
