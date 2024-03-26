using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodManager : MonoBehaviour
{
    public Image foodBar;
    public float foodValue = 100.0f;
    private const float foodDropOverTime = 10.0f;
    public TextMeshProUGUI foodPercentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (foodValue > 0) foodValue -= foodDropOverTime * Time.deltaTime;
        foodBar.fillAmount = foodValue / 100.0f;
        string foodPercentageText = $"{((int)foodValue).ToString()}%";
        foodPercentage.SetText(foodPercentageText);
    }
}