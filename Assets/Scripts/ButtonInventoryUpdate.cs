using TMPro;
using UnityEngine;

public class ButtonInventoryUpdate : MonoBehaviour
{
    public int ItemID;
    public TMP_Text QuantityTXT;
    public GameObject InventoryManager;
    void Update()
    {
        QuantityTXT.text = "Amount: " + InventoryManager.GetComponent<InventoryManagerScript>().inventoryItems[3, ItemID].ToString();
    }
}