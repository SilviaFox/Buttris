using System;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldButtonController : MonoBehaviour
{
    InputField inputField;
    int currentValue;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        currentValue = Int32.Parse(inputField.text);
    }

    public void Increase() // Decrease Input Field Via Button
    {
        currentValue ++;
        if (currentValue > 99)
            currentValue = 99;
        inputField.text = currentValue.ToString();
    }

    public void Decrease() // Increase Input Field Via Button
    {
        currentValue --;
        if (currentValue < 6)
            currentValue = 6;
        inputField.text = currentValue.ToString();
    }

    public void SetString(string input) // Change Input Field Via Typing
    {
        if (input == "" || input == "-" || Int32.Parse(input) < 6)
        {
                currentValue = 6;
                inputField.text = currentValue.ToString();
        }
    }
}
