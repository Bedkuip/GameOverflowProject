using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public TMP_Text PriceTXT;
    public TMP_Text QuantityTXT;
    public GameObject ShopManager;

    // Update is called once per frame
    void Update()
    {
        PriceTXT.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTXT.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
    }
}
