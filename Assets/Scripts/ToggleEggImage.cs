using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ToggleEggImage : MonoBehaviour
{
    public Image imageDisplay;
    public Sprite[] imagesToToggle;
    public Vector2[] scales; // Array to hold scales for each image
    private int clickCount = 0;

    public void ToggleImage()
    {
        // click count
        clickCount++;
        Debug.Log("Click count: " + clickCount);
        // If click count reaches 4, change scene
        if (clickCount == 3)
        {
            Debug.Log("Changing scene...");
            SceneManager.LoadScene("Main");
            return;
        }

        // Change the sprite of the image to the one at the current index
        imageDisplay.sprite = imagesToToggle[clickCount];

        // Change the scale of the image
        imageDisplay.rectTransform.localScale = scales[clickCount];
    }
}
