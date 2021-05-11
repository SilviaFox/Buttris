using UnityEngine;
using UnityEngine.UI;

public class ModeName : MonoBehaviour
{
    Text modeText;

    private void Start()
    {
        modeText = GetComponent<Text>();
        modeText.text = GameSettings.modeName;
    }
}
