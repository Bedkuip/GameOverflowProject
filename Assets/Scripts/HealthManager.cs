using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthValue = 100.0f;
    private const float healthDropOverTime = 5.0f;
    public FoodManager FoodManager;
    public TMPro.TextMeshProUGUI healthPercentage;
    void Update()
    {
        if (FoodManager.foodValue <= 1 && healthValue > 0)
        {
            healthValue -= healthDropOverTime * Time.deltaTime;
        }
        if (healthValue > 100)
        {
            healthValue = 100;
        }
        healthBar.fillAmount = healthValue / 100.0f;
        string foodPercentageText = $"{(int)healthValue}%";
        healthPercentage.SetText(foodPercentageText);
    }
}