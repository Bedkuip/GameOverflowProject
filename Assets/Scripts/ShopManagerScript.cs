using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[6,6];
    public TextMeshProUGUI MoneyTXTnumber;
    public CoinClicker MoneyClicker;
    public InventoryManagerScript InvManager;
    void Start()
    {
        // ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        // Price
        shopItems[2, 1] = 12;
        shopItems[2, 2] = 5;
        shopItems[2, 3] = 8;
        shopItems[2, 4] = 10;
        shopItems[2, 5] = 15;
        //Quantity
        shopItems[3, 1] = 99;
        shopItems[3, 2] = 99;
        shopItems[3, 3] = 99;
        shopItems[3, 4] = 99;
        shopItems[3, 5] = 99;
    }
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (MoneyClicker.money >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] > 0)
        {
            MoneyClicker.money -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]--;
            MoneyTXTnumber.text = MoneyClicker.money.ToString();
            InvManager.Add(ButtonRef.GetComponent<ButtonInfo>().ItemID);
        }
    }
}