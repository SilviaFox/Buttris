using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class NewTabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabGroup;

    [HideInInspector] public Image background;

    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }


    // Start is called before the first frame update
    void Awake()
    {
        background = GetComponent<Image>();
        // tabGroup.Subscribe(this);
    }

    public void Select() 
    {
        if (onTabSelected != null)
            onTabSelected.Invoke();
    }

    public void Deselect()
    {
        if (onTabDeselected != null)
            onTabDeselected.Invoke();

    }
}
