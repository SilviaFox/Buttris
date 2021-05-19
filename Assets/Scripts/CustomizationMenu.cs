using UnityEngine;
using UnityEngine.UI;

public class CustomizationMenu : MonoBehaviour
{
    public Sprite defaultBlockSkin;
    [SerializeField] Image blockSkinButton;
    
    // Start is called before the first frame update
    void Awake()
    {
        CustomizableOptions.blockSkin = defaultBlockSkin;
        UpdateBlockSkinSprite();
    }

    // Update is called once per frame
    public void UpdateBlockSkinSprite()
    {
        blockSkinButton.sprite = CustomizableOptions.blockSkin;
    }
}
