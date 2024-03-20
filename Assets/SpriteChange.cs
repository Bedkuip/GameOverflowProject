using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite sp1, sp2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
    }
}