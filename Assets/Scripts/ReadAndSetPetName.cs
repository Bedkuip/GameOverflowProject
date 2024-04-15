using UnityEngine;
using TMPro;

public class ReadAndSetPetName : MonoBehaviour
{
    private string textInput;
    public static string newPetName = "";
    public TextMeshProUGUI newNameText;
    public void ReadPetNameInput(string petName)
    {
        textInput = petName;
        newPetName = textInput;
        SetPetName();
    }
    public void SetPetName()
    {
        newNameText.text = newPetName;
    }
}