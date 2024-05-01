using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryManagerScript : MonoBehaviour
{
    public int[,] inventoryItems = new int[6,6];
    public ShopManagerScript ShopManager;
    public FoodManager FoodManager;
    public HealthManager HealthManager;
    public HappinessManager HappinessManager;
    void Start()
    {
        // ID
        inventoryItems[1, 1] = 1;
        inventoryItems[1, 2] = 2;
        inventoryItems[1, 3] = 3;
        inventoryItems[1, 4] = 4;
        inventoryItems[1, 5] = 5;
        // Stat increase
        inventoryItems[2, 1] = 40;   // Sushi
        inventoryItems[2, 2] = 15;   // Apple
        inventoryItems[2, 3] = 20;   // Candy
        inventoryItems[2, 4] = 30;   // Coffee
        inventoryItems[2, 5] = 25;   // Medicine
        //Quantity
        inventoryItems[3, 1] = 0;
        inventoryItems[3, 2] = 0;
        inventoryItems[3, 3] = 0;
        inventoryItems[3, 4] = 0;
        inventoryItems[3, 5] = 0;
    }
    public void Add(int buttonID)
    {
        inventoryItems[3, buttonID]++;
    }
    public void Use()
    {
        GameObject CurrentButton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (inventoryItems[3, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID] > 0)
        {
            inventoryItems[3, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID]--;
            if (CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID == 5)
            {
                if (HealthManager.healthValue < 100)
                {
                    HealthManager.healthValue += inventoryItems[2, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID];
                    HappinessManager.happinessValue += 20;
                }
            }
            else
            {
                if (FoodManager.foodValue < 100)
                {
                    FoodManager.foodValue += inventoryItems[2, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID];
                    HappinessManager.happinessValue += 20;
                }
            }
        }
    }
}