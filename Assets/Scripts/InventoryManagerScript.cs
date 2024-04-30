/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class InventoryManagerScript : MonoBehaviour
{
    public int[,] inventoryItems = new int[5,5];
    public TextMeshProUGUI MoneyTXTnumber;
    public CoinClicker MoneyClicker;
    void Start()
    {
        //MoneyTXTnumber.text = MoneyClicker.money.ToString();
        // ID
        inventoryItems[1, 1] = 1;
        inventoryItems[1, 2] = 2;
        inventoryItems[1, 3] = 3;
        inventoryItems[1, 4] = 4;
        
        // Price
        inventoryItems[2, 1] = 0;
        inventoryItems[2, 2] = 0;
        inventoryItems[2, 3] = 0;
        inventoryItems[2, 4] = 0;
        //Quantity
        inventoryItems[3, 1] = 0;
        inventoryItems[3, 2] = 0;
        inventoryItems[3, 3] = 0;
        inventoryItems[3, 4] = 0;
    }
    public void Move() // prev Buy
    {
        GameObject ButtonInfo = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        
        if (MoneyClicker.money >= inventoryItems[2, ButtonInfo.GetComponent<ButtonInfo>().ItemID] && inventoryItems[3, ButtonInfo.GetComponent<ButtonInfo>().ItemID] > 0)
        {
            //MoneyClicker.money -= inventoryItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            inventoryItems[3, ButtonInfo.GetComponent<ButtonInventoryUpdate>().ItemID]++;
            //MoneyTXTnumber.text = MoneyClicker.money.ToString();
            ButtonInfo.GetComponent<ButtonInventoryUpdate>().QuantityTXT.text = inventoryItems[3, ButtonInfo.GetComponent<ButtonInventoryUpdate>().ItemID].ToString();
        }
        
    }
}
*/
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class InventoryManagerScript : MonoBehaviour
{
    public int[,] inventoryItems = new int[5, 5];

    void Start()
    {
        // Initialize your inventory items here (ID, Price, Quantity, etc.)
        // ...

        // Example initialization:
        inventoryItems[1, 1] = 1;
        inventoryItems[1, 2] = 2;
        inventoryItems[1, 3] = 3;
        inventoryItems[1, 4] = 4;
        // Price
        inventoryItems[2, 1] = 0;
        inventoryItems[2, 2] = 0;
        inventoryItems[2, 3] = 0;
        inventoryItems[2, 4] = 0;
        //Quantity
        inventoryItems[3, 1] = 0;
        inventoryItems[3, 2] = 0;
        inventoryItems[3, 3] = 0;
        inventoryItems[3, 4] = 0;
    }

    public void Use(int id)
    {
        GameObject ButtonInfo = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        int itemID = id;//ButtonInfo.GetComponent<ButtonInfo>().ItemID;
        // Increase quantity by 1
        inventoryItems[3, itemID]++;

        // Update UI (assuming you have a Text component for displaying quantity)
        ButtonInfo.GetComponent<ButtonInventoryUpdate>().QuantityTXT.text = inventoryItems[3, itemID].ToString();
    }
}