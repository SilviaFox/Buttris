using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class BlockSkinTab : MonoBehaviour
{
    private void Awake()
    {
        List<Sprite> sprites = new List<Sprite>();


        foreach (Transform skin in transform)
        {
            sprites.Add(skin.GetChild(0).GetComponent<Image>().sprite);
        }

        CustomizationMenu.blockSkins = sprites.ToArray();
        CustomizableOptions.blockSkin = CustomizationMenu.blockSkins[PlayerPrefs.GetInt("BlockSkin", 0)];
    }

}
