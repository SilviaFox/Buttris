using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CustomizationMenu : MonoBehaviour
{
    public static CustomizationMenu current;
    
    [SerializeField] Image blockSkinButton;
    public static Sprite[] blockSkins;

    [SerializeField] GameObject skinTab;
    [SerializeField] GameObject blockSkinSelection;

    // Start is called before the first frame update
    void OnEnable()
    {
        current = this;
        UpdateBlockSkinSprite();
    }

    // Update is called once per frame
    public void UpdateBlockSkinSprite()
    {
        blockSkinButton.sprite = CustomizableOptions.blockSkin;
    }
}
