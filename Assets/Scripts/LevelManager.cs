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
<<<<<<< HEAD
    private AudioSource mainMenuMusic;
=======
>>>>>>> parent of f945a7c (Bedkuip/CodeAnalyserBranch(breaks-game-audio))

    private void Start()
    {
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
        backgroundMusic.Play();
    }
}