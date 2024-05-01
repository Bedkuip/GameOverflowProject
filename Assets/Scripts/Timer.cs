using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static int timePlayed = 0;
    void Start()
    {
        StartCoroutine(GameCounter());
    }
    IEnumerator GameCounter()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        while (true)
        {
            yield return wfs;
            timePlayed++;
        }
    }
}