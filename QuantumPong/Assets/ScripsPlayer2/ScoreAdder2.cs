using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreAdder2 : MonoBehaviour
{
    public TextMeshProUGUI score;
    int PlayerScore2 = 0;
    public bool end = false;
    public GameObject ball;
    Vector3 origen = new Vector3 (0, 0, -0.187f);
    GameObject BallManager;
    BallManager BallManagerScript;
    GameObject SoundManager;
    SoundManager SoundManagerScript;

    void Start()
    {
        BallManager = GameObject.Find("BallManager");
        BallManagerScript = BallManager.GetComponent<BallManager>();
        SoundManager = GameObject.Find("SoundManager");
        SoundManagerScript = SoundManager.GetComponent<SoundManager>();
    }
    void Update()
    {  
       if(PlayerScore2 == 9)
       {
           end = true;
       }
    }
    
    void OnTriggerEnter(Collider other)
    {
       Destroy (other.gameObject);
       PlayerScore2 += 1;
       score.text = PlayerScore2.ToString();
       BallManagerScript.leftGetPoint = true;
       BallManagerScript.rightGetPoint = false;
       SoundManagerScript.scoreSound.Play();

        if(end == false)
        {
            Instantiate(ball, origen, Quaternion.identity);
        }
    }
}
