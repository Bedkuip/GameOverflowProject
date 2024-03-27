using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CoinClicker : MonoBehaviour
{
    public TextMeshProUGUI MoneyTXTnumber;
    public int money;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        money++;
        MoneyTXTnumber.text = money.ToString();
    }
}