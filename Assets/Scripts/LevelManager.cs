using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneName;
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

public class MusicController : MonoBehaviour
{
    private AudioSource backgroundMusic;
    private AudioSource mainMenuMusic; // Added this line to resolve the conflict

    private void Start()
    {
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
        backgroundMusic.Play();
    }
}
