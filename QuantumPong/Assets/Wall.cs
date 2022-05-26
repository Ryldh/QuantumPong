using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    GameObject SoundManager;
    SoundManager SoundManagerScript;
    void Start()
    {
        SoundManager = GameObject.Find("SoundManager");
        SoundManagerScript = SoundManager.GetComponent<SoundManager>();

        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider ball)
    {
        ball.gameObject.GetComponent<Ball>().sY *= -1;
        SoundManagerScript.wallSound.pitch = 1;
        SoundManagerScript.wallSound.Play();
    }
}
