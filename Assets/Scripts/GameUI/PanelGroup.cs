using UnityEngine;
using UnityEngine.EventSystems;

public class PanelGroup : MonoBehaviour
{
    [Header("Panels")]
    public GameObject[] panels;
    public GameObject[] selectedObjects;
    [Header("Sub-Panels")]
    public GameObject[] subPanels;
    public GameObject[] subSelectedObjects;

    public TabGroup tabGroup;

    int panelIndex;
    int subPanelIndex;

    private void Start()
    {
        ShowCurrentPanel();
    }

    void ShowCurrentPanel()
    {
        subPanels[subPanelIndex].SetActive(false);

        for (int i = 0; i < panels.Length; i++)
        {
            if (i == panelIndex)
            {
                panels[i].gameObject.SetActive(true);
                EventSystem.current.SetSelectedGameObject(selectedObjects[i]);
            }
            else
                panels[i].gameObject.SetActive(false);
        }

    }

    public void SetPageIndex(int index)
    {
        panelIndex = index;
        ShowCurrentPanel();
    }

    public void ShowSubPage(int index)
    {
        panels[panelIndex].SetActive(false);

        subPanels[index].SetActive(true);
        EventSystem.current.SetSelectedGameObject(subSelectedObjects[index]);
        
    }

    public void RestorePage()
    {
        panels[panelIndex].SetActive(true);

        subPanels[subPanelIndex].SetActive(false);
        
    }
}
