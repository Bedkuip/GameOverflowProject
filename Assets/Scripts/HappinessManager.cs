using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HappinessManager : MonoBehaviour
{
    public Image happinessBar;
    public float happinessValue = 100.0f;
    private const float happinessDropOverTime = 1.0f;
    public FoodManager FoodManager;
    public TextMeshProUGUI happinessPercentage;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (FoodManager.foodValue <= 20 && happinessValue > 0)
        {
            happinessValue -= happinessDropOverTime * Time.deltaTime;
        }
        happinessBar.fillAmount = happinessValue / 100.0f;
        string foodPercentageText = $"{((int)happinessValue).ToString()}%";
        happinessPercentage.SetText(foodPercentageText);
    }
}