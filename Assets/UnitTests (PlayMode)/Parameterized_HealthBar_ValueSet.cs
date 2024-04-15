using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Parameterized_HealthBar_ValueSet : InputTestFixture
{
    public override void Setup()
    {
        base.Setup();
        SceneManager.LoadScene("Main");
    }
    static int[] setValues = new int[] { 75, 50, 0 };
    [UnityTest]
    public IEnumerator Parameterized_HealthBar_ValueSetCheck([ValueSource("setValues")] int setValue)
    {
        GameObject healthBar = GameObject.Find("Canvas/UIbar/HealthBar/Value/HealthManager");
        HealthManager healthValue = healthBar.GetComponent<HealthManager>();
        healthValue.healthValue = setValue;
        yield return new WaitForSeconds(1);
        int currentHealthValue = (int)healthValue.healthValue;
        Assert.AreEqual(setValue, currentHealthValue, "Current health value doesn't match the set value");
    }
}