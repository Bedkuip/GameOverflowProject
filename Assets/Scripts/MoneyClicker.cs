using UnityEngine;
using TMPro;

public class CoinClicker : MonoBehaviour
{
    public TextMeshProUGUI MoneyTXTnumber;
    public int money;
    public static int totalMoneyGained;
    void Start()
    {
        totalMoneyGained = 0;
    }
    public int GetMoneyCount()
    {
        return money;
    }
    public void OnClick()
    {
        money++;
        totalMoneyGained++;
        MoneyTXTnumber.text = money.ToString();
    }
}