using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ToggleEggImage : MonoBehaviour
{
    public Button eggButton;
    public Button continueButton;
    public TextMeshProUGUI newNameText;
    public Image imageDisplay;
    public Sprite[] imagesToToggle;
    public Vector2[] scales; // Array to hold scales for each image
    private int clickCount = 0;
    public void ToggleImage()
    {
        clickCount++;
        // If click count reaches 5, make continue button and name field visible
        if (clickCount == 5)
        {
            continueButton.gameObject.SetActive(true);
            newNameText.gameObject.SetActive(true);
            eggButton.enabled = false;
            return;
        }
        // Change the sprite of the image to the one at the current index
        imageDisplay.sprite = imagesToToggle[clickCount];
        // Change the scale of the image
        imageDisplay.rectTransform.localScale = scales[clickCount];
    }
}