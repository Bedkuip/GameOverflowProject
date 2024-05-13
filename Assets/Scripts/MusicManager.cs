using Palmmedia.ReportGenerator.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private AudioSource mainMenuMusic;
    private void Start()
    {
        mainMenuMusic = GameObject.Find("MainMenuMusic").GetComponent<AudioSource>();
        if(mainMenuMusic  != null )
            mainMenuMusic.Play();
    }
}