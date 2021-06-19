using UnityEngine;
using UnityEngine.UI;

public class BlockSkinButton : MonoBehaviour
{
    private void OnEnable()
    {
        transform.localScale = new Vector3(0,0);
        LeanTween.scale(this.gameObject, new Vector3(1,1,1), 0.5f).setEaseOutBounce();
    }

    public void OnSelection() 
    {
        PlayerPrefs.SetInt("BlockSkin", transform.GetSiblingIndex());

        CustomizableOptions.blockSkin = CustomizationMenu.blockSkins[transform.GetSiblingIndex()];
        CustomizationMenu.current.UpdateBlockSkinSprite();
        transform.parent.transform.parent.gameObject.GetComponent<PanelGroup>().RestorePage();

    }
}
