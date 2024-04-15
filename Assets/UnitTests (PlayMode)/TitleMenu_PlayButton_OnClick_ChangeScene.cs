using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleMenu_PlayButton_OnClick_ChangeScene : InputTestFixture
{
    public override void Setup()
    {
        base.Setup();
        SceneManager.LoadScene("TitleMenu");
    }
    [UnityTest]
    public IEnumerator TitleMenu_PlayButton_OnClick_ChangeSceneCheck()
    {
        GameObject playButton = GameObject.Find("Canvas/TitleScreen/PlayButton");
        Button button = playButton.GetComponent<Button>();
        button.onClick.Invoke();
        yield return null;
        string sceneName = SceneManager.GetActiveScene().name;
        Assert.That(sceneName, Is.EqualTo("EggMenu"), "The current scene doesn't match the expected one");
    }
}