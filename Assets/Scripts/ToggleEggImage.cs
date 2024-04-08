using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ToggleEggImage : MonoBehaviour
{
    public Image ImageDisplayGameObject;
    public Sprite ImageToActive;
    public void ShowImage()
    {
        ImageDisplayGameObject.sprite = ImageToActive;
    }
}
