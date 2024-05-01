using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[7,7];
    public TextMeshProUGUI MoneyTXTnumber;
    public CoinClicker MoneyClicker;
    public InventoryManagerScript InvManager;
    public static int totalMoneySpent;
    void Start()
    {
        // ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        // Price
        shopItems[2, 1] = 10;   // Sushi
        shopItems[2, 2] = 3;    // Apple
        shopItems[2, 3] = 5;    // Candy
        shopItems[2, 4] = 8;    // Coffee
        shopItems[2, 5] = 15;   // Pill
        shopItems[2, 6] = 25;   // Health potion
        // Quantity
        shopItems[3, 1] = 99;
        shopItems[3, 2] = 99;
        shopItems[3, 3] = 99;
        shopItems[3, 4] = 99;
        shopItems[3, 5] = 99;
        shopItems[3, 6] = 99;
        // Set money spent to 0
        totalMoneySpent = 0;
    }
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (MoneyClicker.money >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] > 0)
        {
            MoneyClicker.money -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            totalMoneySpent += shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]--;
            MoneyTXTnumber.text = MoneyClicker.money.ToString();
            InvManager.Add(ButtonRef.GetComponent<ButtonInfo>().ItemID);
        }
    }
}