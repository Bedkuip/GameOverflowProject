using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FoodBar_OverTime_Decreases : InputTestFixture
{
    public FoodManager FoodManager;
    public override void Setup()
    {
        base.Setup();
        SceneManager.LoadScene("Main");
    }
    [UnityTest]
    public IEnumerator FoodBar_OverTime_DecreasesCheck()
    {
        GameObject foodBar = GameObject.Find("Canvas/UIbar/FoodBar/Value/FoodManager");
        FoodManager foodValue = foodBar.GetComponent<FoodManager>();
        yield return new WaitForSeconds(5);
        int currentFoodValue = (int)foodValue.foodValue;
        Assert.LessOrEqual(currentFoodValue, 75, "Food value amount is not less or equal than the set value");
    }
}