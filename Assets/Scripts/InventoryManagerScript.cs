using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class InventoryManagerScript : MonoBehaviour
{
    public int[,] inventoryItems = new int[5,5];
    //public TextMeshProUGUI MoneyTXTnumber;
    //public CoinClicker MoneyClicker;
    void Start()
    {
        //MoneyTXTnumber.text = MoneyClicker.money.ToString();
        // ID
        inventoryItems[1, 1] = 1;
        inventoryItems[1, 2] = 2;
        inventoryItems[1, 3] = 3;
        inventoryItems[1, 4] = 4;
        /*
        // Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;*/
        //Quantity
        inventoryItems[3, 1] = 0;
        inventoryItems[3, 2] = 0;
        inventoryItems[3, 3] = 0;
        inventoryItems[3, 4] = 0;
    }
    public void Move() // prev Buy
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        /*
        if (MoneyClicker.money >= inventoryItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && inventoryItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] > 0)
        {
            //MoneyClicker.money -= inventoryItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            inventoryItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]--;
            //MoneyTXTnumber.text = MoneyClicker.money.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = inventoryItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
        */
    }
}