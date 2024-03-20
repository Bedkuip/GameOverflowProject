using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthValue = 100.0f;
    private const float healthDropOverTime = 1.0f;
    public FoodManager FoodManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (FoodManager.foodValue <= 0)
        {
            healthValue -= healthDropOverTime * Time.deltaTime;
        }
        healthBar.fillAmount = healthValue / 100.0f;
    }
}