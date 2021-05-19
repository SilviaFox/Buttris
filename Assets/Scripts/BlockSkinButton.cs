using UnityEngine;
using UnityEngine.UI;

public class BlockSkinButton : MonoBehaviour
{
    [SerializeField] Image skinSprite;

    private void OnEnable()
    {
        transform.localScale = new Vector3(0,0);
        LeanTween.scale(this.gameObject, new Vector3(1,1,1), 0.5f).setEaseOutBounce();
    }

    public void OnSelection() 
    {
        CustomizableOptions.blockSkin = skinSprite.sprite;
        transform.parent.transform.parent.gameObject.GetComponent<PanelGroup>().RestorePage();

    }
}
