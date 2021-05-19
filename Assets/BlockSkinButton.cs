using UnityEngine;
using UnityEngine.UI;

public class BlockSkinButton : MonoBehaviour
{
    [SerializeField] Image skinSprite;

    public void OnSelection() 
    {
        CustomizableOptions.blockSkin = skinSprite.sprite;
        transform.parent.transform.parent.gameObject.GetComponent<PanelGroup>().RestorePage();

    }
}
