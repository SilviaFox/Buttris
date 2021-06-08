using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public static TabGroup activeTabGroup;

    public List<NewTabButton> tabButtons;
    public Color tabIdle;
    public Color tabHover;
    public Color tabActive;
    public NewTabButton selectedTab;
    // public List<GameObject> objectsToSwap;

    public PanelGroup panelGroup;

    private void Start()
    {
        activeTabGroup = this;
        
        
        OnTabSelected(tabButtons[0]);
        
    }

    // Keyboard or Controller input for changing tabs
    public void ChangeActiveTabL()
    {

        if ((selectedTab.transform.GetSiblingIndex()) > 0)
        {
            OnTabSelected(tabButtons[selectedTab.transform.GetSiblingIndex() - 1]);
        }
        else
        {
            OnTabSelected(tabButtons[transform.childCount - 1]);
        }
    }
    public void ChangeActiveTabR()
    {

        if (selectedTab.transform.GetSiblingIndex() < transform.childCount-1)
        {
            OnTabSelected(tabButtons[selectedTab.transform.GetSiblingIndex() + 1]);
        }
        else
        {
            OnTabSelected(tabButtons[0]);
        }
    }

    public void Subscribe(NewTabButton button)
    {
        if (tabButtons == null)
            tabButtons = new List<NewTabButton>();
        
        tabButtons.Add(button);

    }

    // Mouse interaction with tabs

    public void OnTabEnter(NewTabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
            // button.background.color = tabHover;
            StartCoroutine(BlendColors(button.background, tabHover));
    }

    public void OnTabExit(NewTabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected (NewTabButton button)
    {
        if (selectedTab != null)
        {
            selectedTab.Deselect();
        }

        selectedTab = button;

        selectedTab.Select();

        ResetTabs();
        // button.background.color = tabActive;
        StartCoroutine(BlendColors(button.background, tabActive));
        // int index = button.transform.GetSiblingIndex();
        

        // for (int i = 0; i < objectsToSwap.Count; i++)
        // {
        //     if (i == index)
        //         objectsToSwap[i].SetActive(true);
        //     else
        //         objectsToSwap[i].SetActive(false);
        // }
        if (panelGroup != null)
        {
            panelGroup.SetPageIndex(selectedTab.transform.GetSiblingIndex());
        }
    }

    public void ResetTabs()
    {
        StopAllCoroutines();

        foreach(NewTabButton button in tabButtons)
        {
            if (selectedTab!=null && button == selectedTab) {continue;}

            // button.background.color = tabIdle;
            StartCoroutine(BlendColors(button.background, tabIdle));
        }

    }

    IEnumerator BlendColors(Image image, Color endColor)
    {

        while (image.color != endColor)
        {
            image.color = Color.Lerp(image.color, endColor, 0.2f);
            yield return new WaitForFixedUpdate();
        }
    }



    
}
