using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInventoryUpdate : MonoBehaviour
{
    public int ItemID;
    //public TMP_Text PriceTXT;
    public TMP_Text QuantityTXT;
    public GameObject InventoryManager;

    // Update is called once per frame
    void Update()
    {
        //PriceTXT.text = "Price: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString() + "$";
        QuantityTXT.text = "Quantity: " + InventoryManager.GetComponent<InventoryManagerScript>().inventoryItems[3, ItemID].ToString();
    }
}