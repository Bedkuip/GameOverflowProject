using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthValue = 100.0f;
    private const float healthDropOverTime = 0.5f;
    public FoodManager FoodManager;
    public TextMeshProUGUI healthPercentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (FoodManager.foodValue <= 1 && healthValue > 0)
        {
            healthValue -= healthDropOverTime * Time.deltaTime;
        }
        healthBar.fillAmount = healthValue / 100.0f;
        string foodPercentageText = $"{((int)healthValue).ToString()}%";
        healthPercentage.SetText(foodPercentageText);
    }
}