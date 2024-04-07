using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class MoneyCounter_OnClick_Increases : InputTestFixture
{
    public CoinClicker moneyClicker;
    public TextMeshProUGUI moneyCountValue;
    public override void Setup()
    {
        base.Setup();
        SceneManager.LoadScene("Main");
    }
    [UnityTest]
    public IEnumerator MoneyCounter_OnClick_IncreasesCheck()
    {
        GameObject moneyButton = GameObject.Find("Canvas/MoneyButton");
        Button button = moneyButton.GetComponent<Button>();
        bool buttonClicked = false;
        button.onClick.AddListener(() => { buttonClicked = true; });
        yield return new WaitForSeconds(1);
        button.onClick.Invoke();
        yield return new WaitForSeconds(1);
        button.onClick.Invoke();
        Assert.IsTrue(buttonClicked, "Money button was not clicked");
        GameObject moneyCount = GameObject.Find("Canvas/UIbar/MoneyTXTNumber");
        string moneyCountText = moneyCount.GetComponent<TextMeshProUGUI>().text.ToString();
        Assert.AreEqual("2", moneyCountText, "Money count doesn't match the expected amount");
    }
}