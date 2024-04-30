using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    [UnityTest]
    public IEnumerator TestScriptSimpleEnumerator()
    {
        // Arrange
        int a = 16;
        int b = 3;

        // Act
        int result = a / b;

        // Assert
        Assert.AreEqual(5, result);

        // Yield to skip a frame
        yield return null;
    }
}
public class TestScriptParametrized
{
    [TestCase(3, 4, 7)]
    [TestCase(10, 20, 30)]
    [TestCase(1, -5, -4)]
    public void TestScriptWithParameters(int a, int b, int expectedSum)
    {
        // Act 
        int result = a + b;

        // Assert
        Assert.AreEqual(expectedSum, result);
    }
}
public class TestScriptExpansion
{
    [Test]
    public void TestScriptwithCycle()
    {
        // Arrange
        int[] ints = { 1, 2, 3, 4, 5, 6 };
        int result = 0;
     
        // Act
        for (int i = 0; i < ints.Length; i++) 
            result += ints[i];
        // Assert
        Assert.AreEqual(21, result);
    }
}
