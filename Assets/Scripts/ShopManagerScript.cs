using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[5,5];
    public TextMeshProUGUI MoneyTXTnumber;
    public CoinClicker MoneyClicker;
    public InventoryManagerScript inventoryManager;

    void Start()
    {
        // ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        // Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;
        //Quantity
        shopItems[3, 1] = 5;
        shopItems[3, 2] = 5;
        shopItems[3, 3] = 5;
        shopItems[3, 4] = 5;
    }
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (MoneyClicker.money >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] > 0)
        {
            MoneyClicker.money -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]--;
            MoneyTXTnumber.text = MoneyClicker.money.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            //inventoryManager.Buy(shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]);

            //targetButton.GetComponent<ButtonInfo>().QuantityTXT.text = shopItems[3, ItemID].ToString();
        }
    }
    public void Move()
    {
        GameObject gameObject = GameObject.Find("Item1");
    }
}