using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using NSubstitute;

public class Mock_CoinClicker : InputTestFixture
{
    public override void Setup()
    {
        base.Setup();
        SceneManager.LoadScene("Main");
    }
    [UnityTest]
    public IEnumerator Mock_CoinClickerCheck()
    {
        var coinClickerMock = Substitute.For<MockableCoinClicker>();
        coinClickerMock.GetMoneyCount().Returns(0, 1, 2, 3);
        coinClickerMock.When(x => x.OnClick()).Do(x => coinClickerMock.money++);
        coinClickerMock.OnClick();
        yield return null;
        coinClickerMock.OnClick();
        yield return null;
        coinClickerMock.OnClick();
        yield return null;
        Assert.AreEqual(3, coinClickerMock.money, "Money count doesn't match the expected amount");
    }
}