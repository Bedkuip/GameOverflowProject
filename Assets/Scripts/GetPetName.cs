using UnityEngine;
using TMPro;

public class GetPetName : MonoBehaviour
{
    public TextMeshProUGUI petName;
    public void Start()
    {
        petName.text = ReadAndSetPetName.newPetName;
    }
}