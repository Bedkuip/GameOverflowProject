using UnityEngine;
using TMPro;

public class CoinClicker : MonoBehaviour
{
    public TextMeshProUGUI MoneyTXTnumber;
    public int money;
    public int GetMoneyCount()
    {
        return money;
    }
    public void OnClick()
    {
        money++;
        MoneyTXTnumber.text = money.ToString();
    }
}