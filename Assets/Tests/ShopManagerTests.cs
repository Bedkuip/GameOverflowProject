using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TestTools;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    void Start()
    {
        //MoneyTXTnumber.text = MoneyClicker.money.ToString();
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
}

public class ShopManagerTests
{
    private ShopManagerScript shopManager;

    [SetUp]
    public void Setup()
    {
        // Initialize the ShopManagerScript 
        shopManager = new GameObject().AddComponent<ShopManagerScript>();
    }

    [Test]
    public void Buy_DeductsMoneyAndUpdatesQuantity()
    {
        // Sets initial money and item quantities
        shopManager.shopItems[2, 1] = 10;
        shopManager.shopItems[3, 1] = 5;

        // Verifies that the money is deducted and quantity is updated
        Assert.AreEqual(4, shopManager.shopItems[3, 1]);
    }
}