using UnityEngine;
using TMPro;

public class StatSummary : MonoBehaviour
{
    public TMP_Text TimeSurvived;
    public TMP_Text MoneyGained;
    public TMP_Text MoneySpent;
    void Start()
    {
        TimeSurvived.text = Timer.timePlayed.ToString() + " seconds";
        MoneyGained.text = CoinClicker.totalMoneyGained.ToString() + " $";
        MoneySpent.text = ShopManagerScript.totalMoneySpent.ToString() + " $";
    }
}
