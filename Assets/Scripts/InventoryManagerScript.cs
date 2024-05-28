using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryManagerScript : MonoBehaviour
{
    public int[,] inventoryItems = new int[7,7];
    public ShopManagerScript ShopManager;
    public FoodManager FoodManager;
    public HealthManager HealthManager;
    public HappinessManager HappinessManager;
    public GameObject FloatingText;
    void Start()
    {
        // ID
        inventoryItems[1, 1] = 1;
        inventoryItems[1, 2] = 2;
        inventoryItems[1, 3] = 3;
        inventoryItems[1, 4] = 4;
        inventoryItems[1, 5] = 5;
        inventoryItems[1, 6] = 6;
        // Stat increase
        inventoryItems[2, 1] = 40;   // Sushi
        inventoryItems[2, 2] = 15;   // Apple
        inventoryItems[2, 3] = 20;   // Candy
        inventoryItems[2, 4] = 30;   // Coffee
        inventoryItems[2, 5] = 25;   // Pill
        inventoryItems[2, 6] = 50;   // Health potion
        // Quantity
        inventoryItems[3, 1] = 0;
        inventoryItems[3, 2] = 0;
        inventoryItems[3, 3] = 0;
        inventoryItems[3, 4] = 0;
        inventoryItems[3, 5] = 0;
        inventoryItems[3, 6] = 0;
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
            // Popup text
            GameObject floatingText = Instantiate(FloatingText, transform.position, Quaternion.identity) as GameObject;
            GameObject floatingText2 = Instantiate(FloatingText, transform.position, Quaternion.identity) as GameObject;
            if (CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID == 5 || CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID == 6)
            {
                HealthManager.healthValue += inventoryItems[2, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID];
                HappinessManager.happinessValue += 20;
                floatingText.transform.localPosition += new Vector3(0, 100f, 0);
                floatingText.transform.GetChild(0).GetComponent<TextMesh>().color = new Color32(250, 102, 150, 255);
                floatingText.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + inventoryItems[2, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID].ToString();
                floatingText2.transform.localPosition += new Vector3(0, -100f, 0);
                floatingText2.transform.GetChild(0).GetComponent<TextMesh>().color = new Color32(244, 235, 137, 255);
                floatingText2.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + 20.ToString();
            }
            else
            {
                FoodManager.foodValue += inventoryItems[2, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID];
                HappinessManager.happinessValue += 20;
                floatingText.transform.GetChild(0).GetComponent<TextMesh>().color = new Color32(132, 77, 57, 255);
                floatingText.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + inventoryItems[2, CurrentButton.GetComponent<ButtonInventoryUpdate>().ItemID].ToString();
                floatingText2.transform.localPosition += new Vector3(0, -100f, 0);
                floatingText2.transform.GetChild(0).GetComponent<TextMesh>().color = new Color32(244, 235, 137, 255);
                floatingText2.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + 20.ToString();
            }
        }
    }
}