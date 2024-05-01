using TMPro;
using UnityEngine;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public TMP_Text PriceTXT;
    public TMP_Text QuantityTXT;
    public GameObject ShopManager;
    void Update()
    {
        PriceTXT.text = "Price: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString() + "$";
        QuantityTXT.text = "Amount: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
    }
}