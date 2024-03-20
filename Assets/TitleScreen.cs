using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Enter Next Scene here"); // Needs a Valid Scene (Egg hatch scene?)
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
