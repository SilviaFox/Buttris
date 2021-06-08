using UnityEngine;
using UnityEngine.UI;
using System;

public class GameTypeEditor : MonoBehaviour
{
    public static GameTypeEditor current;

    public Text[] selections; // Selectable buttons
    Font defaultFont; // Default font for the buttons
    [SerializeField] Font selectedFont; // Font used for the selected text

    [SerializeField] GameObject fadeToBlack;
    [HideInInspector] public int selectedArea; // Currently selected button

    private void Start()
    {
        current = this;

        defaultFont = selections[0].font;
        UpdateSelection();
    }
    
    public void StartGame()
    {
        InputScript.input.GameTypeMenu.Disable();

        GameTypeSelectableInfo gameType = selections[0].GetComponent<GameTypeSelectableInfo>();
        GameTypeSelectableInfo condition = selections[1].GetComponent<GameTypeSelectableInfo>();
        GameTypeSelectableInfo level = selections[2].GetComponent<GameTypeSelectableInfo>();

        // Gametype & Conditions
        PresetSettings.gameSettings.SetGameType(gameType.currentOptions[gameType.currentSelection], // Set Gametype
         Int32.Parse(condition.currentOptions[condition.currentSelection])); // Set Conditions for mode
        
        // Level
        GameManager.values.startingLevel = Int32.Parse(level.currentOptions[level.currentSelection]);
        
        // Stop menu music and start game
        AudioManager.instance.StopMusic();
        AudioManager.instance.Play("Pause");
        Instantiate(fadeToBlack).transform.GetChild(0).GetComponent<FadeSceneChange>().sceneToChangeTo = "Game";
    }

    public void UpdateSelection()
    {
        AudioManager.instance.Play("Move");

        if (selectedArea >= selections.Length)
            selectedArea = 0;
        else if (selectedArea < 0)
            selectedArea = selections.Length - 1;
        
        for (int i = 0; i < selections.Length; i++)
        {
            if (i == selectedArea)
                selections[i].font = selectedFont;
            else
                selections[i].font = defaultFont;
        }
    }

    public void CheckForSwaps()
    {

        GameTypeSelectableInfo selectableInfo;
        // If mode was selected
        if(selectedArea == 0)
            for (int i = 0; i < selections.Length - 1; i++)
            {
                selectableInfo = selections[i].GetComponent<GameTypeSelectableInfo>();
                if(selectableInfo.swappableOptions)
                    selectableInfo.SwapOptions(selections[0].GetComponent<GameTypeSelectableInfo>().currentSelection);

            }
    }


}
