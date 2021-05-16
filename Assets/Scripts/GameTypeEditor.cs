using UnityEngine;
using UnityEngine.UI;
using System;

public class GameTypeEditor : MonoBehaviour
{
    
    [SerializeField] Text[] selections; // Selectable buttons
    Font defaultFont; // Default font for the buttons
    [SerializeField] Font selectedFont; // Font used for the selected text
    InputMaster input;

    [SerializeField] GameObject fadeToBlack;
    int selectedArea; // Currently selected button

    private void Start()
    {
        input = new InputMaster();
        input.GameTypeMenu.Enable();
        
        // Up-Down
        input.GameTypeMenu.Down.started += ctx => {selectedArea ++; UpdateSelection();}; 
        input.GameTypeMenu.Up.started += ctx => {selectedArea --; UpdateSelection();};

        // Left-Right
        input.GameTypeMenu.Right.started += ctx => {if (selectedArea != selections.Length - 1) selections[selectedArea].GetComponent<GameTypeSelectableInfo>().SelectionRight(); CheckForSwaps();};
        input.GameTypeMenu.Left.started += ctx => {if (selectedArea != selections.Length - 1) selections[selectedArea].GetComponent<GameTypeSelectableInfo>().SelectionLeft(); CheckForSwaps();};

        input.GameTypeMenu.Start.started += ctx => {if (selectedArea == selections.Length - 1) StartGame();};

        defaultFont = selections[0].font;
        UpdateSelection();
    }
    
    void StartGame()
    {
        input.GameTypeMenu.Disable();
        input = null;
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
        Instantiate(fadeToBlack).GetComponent<FadeSceneChange>().sceneToChangeTo = "Game";
    }

    void UpdateSelection()
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

    void CheckForSwaps()
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
