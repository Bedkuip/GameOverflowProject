using UnityEngine;
using TMPro;
using System.Collections;

public class SpriteChange : MonoBehaviour
{
    public Sprite defSprite, mouthSprite, sadSprite, angrySprite, sickSprite;
    public GameObject statusPopup;
    public TextMeshProUGUI StatusMessage;
    public HealthManager HealthManager;
    public FoodManager FoodManager;
    public HappinessManager HappinessManager;
    public float revertDelay = 0.2f;
    public float previousFoodValue;
    private bool valueIncreased = false;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = defSprite;
        statusPopup.gameObject.SetActive(false);
        previousFoodValue = 100;
    }
    void Update()
    {

        // Normal
        if (FoodManager.foodValue > 50 && HealthManager.healthValue > 50 && HappinessManager.happinessValue > 50)
        {
            GetComponent<SpriteRenderer>().sprite = defSprite;
            statusPopup.gameObject.SetActive(false);
            StatusMessage.text = "";
        }

        // Eats
        else if (FoodManager.foodValue > previousFoodValue && !valueIncreased)
        {
            GetComponent<SpriteRenderer>().sprite = mouthSprite;
            valueIncreased = true;

            StartCoroutine(RevertSprite());
        }
        // Sick
        else if (HealthManager.healthValue <= 50) 
        {
            GetComponent<SpriteRenderer>().sprite = sickSprite;
            statusPopup.gameObject.SetActive(true);
            StatusMessage.text = "I'm sick!";
            if (FoodManager.foodValue <= 50) StatusMessage.text = "I'm sick and hungry!";
            if (FoodManager.foodValue <= 0) StatusMessage.text = "I'm sick and starving!";
            if (FoodManager.foodValue <= 50 && HappinessManager.happinessValue <= 50) StatusMessage.text = "I'm sick and hungry, and sad!";
            if (FoodManager.foodValue <= 0 && HappinessManager.happinessValue <= 50) StatusMessage.text = "I'm sick and starving, and sad!";
        }
        // Sad
            else if (HappinessManager.happinessValue <= 50 &&
                    HappinessManager.happinessValue < HealthManager.healthValue)
                {
                    GetComponent<SpriteRenderer>().sprite = sadSprite;
                    statusPopup.gameObject.SetActive(true);
                    StatusMessage.text = "I'm sad!";
                    if (FoodManager.foodValue <= 50) StatusMessage.text = "I'm sad and hungry!";
                    if (FoodManager.foodValue <= 0) StatusMessage.text = "I'm sad and starving!";
                }
            // Hungry
                else if (FoodManager.foodValue <= 50 &&
                        FoodManager.foodValue < HealthManager.healthValue && FoodManager.foodValue < HappinessManager.happinessValue)
                {
                    GetComponent<SpriteRenderer>().sprite = angrySprite;
                    statusPopup.gameObject.SetActive(true);
                    StatusMessage.text = "I'm hungry!";
                    if (FoodManager.foodValue <= 0) StatusMessage.text = "I'm starving!";
                }
        previousFoodValue = FoodManager.foodValue;
        // Interactable
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GetComponent<SpriteRenderer>().sprite = mouthSprite;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    GetComponent<SpriteRenderer>().sprite = defSprite;
        //}
    }
    private IEnumerator RevertSprite()
    {
        yield return new WaitForSeconds(revertDelay);

        // Normal
        if (FoodManager.foodValue > 50 && HealthManager.healthValue > 50 && HappinessManager.happinessValue > 50)
        {
            GetComponent<SpriteRenderer>().sprite = defSprite;
            statusPopup.gameObject.SetActive(false);
            StatusMessage.text = "";
        }

        // Sick
        else if (HealthManager.healthValue <= 50)
        {
            GetComponent<SpriteRenderer>().sprite = sickSprite;
            statusPopup.gameObject.SetActive(true);
            StatusMessage.text = "I'm sick!";
            if (FoodManager.foodValue <= 50) StatusMessage.text = "I'm sick and hungry!";
            if (FoodManager.foodValue <= 0) StatusMessage.text = "I'm sick and starving!";
            if (FoodManager.foodValue <= 50 && HappinessManager.happinessValue <= 50) StatusMessage.text = "I'm sick and hungry, and sad!";
            if (FoodManager.foodValue <= 0 && HappinessManager.happinessValue <= 50) StatusMessage.text = "I'm sick and starving, and sad!";
        }
        // Sad
        else if (HappinessManager.happinessValue <= 50 &&
                HappinessManager.happinessValue < HealthManager.healthValue)
        {
            GetComponent<SpriteRenderer>().sprite = sadSprite;
            statusPopup.gameObject.SetActive(true);
            StatusMessage.text = "I'm sad!";
            if (FoodManager.foodValue <= 50) StatusMessage.text = "I'm sad and hungry!";
            if (FoodManager.foodValue <= 0) StatusMessage.text = "I'm sad and starving!";
        }
        // Hungry
        else if (FoodManager.foodValue <= 50 &&
                FoodManager.foodValue < HealthManager.healthValue && FoodManager.foodValue < HappinessManager.happinessValue)
        {
            GetComponent<SpriteRenderer>().sprite = angrySprite;
            statusPopup.gameObject.SetActive(true);
            StatusMessage.text = "I'm hungry!";
            if (FoodManager.foodValue <= 0) StatusMessage.text = "I'm starving!";
        }

        valueIncreased = false;
    }
}