using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource endMenuMusic;
    private void Start()
    {
        endMenuMusic = GameObject.Find("EndMusic").GetComponent<AudioSource>();
        if (endMenuMusic != null)
            endMenuMusic.Play();
    }
}
