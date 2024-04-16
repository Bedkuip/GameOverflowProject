using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HappinessManager : MonoBehaviour
{
    public Image happinessBar;
    public float happinessValue = 100.0f;
    private const float happinessDropOverTime = 10.0f; //1.0f
    public FoodManager FoodManager;
    public TextMeshProUGUI happinessPercentage;
    void Update()
    {
        if (FoodManager.foodValue <= 20 && happinessValue > 0)
        {
            happinessValue -= happinessDropOverTime * Time.deltaTime;
        }
        happinessBar.fillAmount = happinessValue / 100.0f;
        string foodPercentageText = $"{(int)happinessValue}%";
        happinessPercentage.SetText(foodPercentageText);
    }
}