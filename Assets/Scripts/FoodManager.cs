using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodManager : MonoBehaviour
{
    public Image foodBar;
    public float foodValue = 100.0f;
    private const float foodDropOverTime = 7.5f;
    public TextMeshProUGUI foodPercentage;
    void Update()
    {
        if (foodValue > 0)
        {
            foodValue -= foodDropOverTime * Time.deltaTime;
        }
        if (foodValue > 100)
        {
            foodValue = 100;
        }
        foodBar.fillAmount = foodValue / 100.0f;
        string foodPercentageText = $"{((int)foodValue).ToString()}%";
        foodPercentage.SetText(foodPercentageText);
    }
}