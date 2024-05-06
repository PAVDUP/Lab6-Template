using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExampleUIScript : MonoBehaviour
{
    public TMP_InputField exampleInputField;
    public TextMeshProUGUI exampleText;
    
    public void OnChangeMessageButtonClicked()
    {
        string inputMessage = exampleInputField.text; // Get the text from the input field - exampleInputField is the reference to the input field
        exampleText.text = inputMessage; // Set the text of the TextMeshProUGUI - exampleText is the reference to the TextMeshProUGUI component
    }
}
