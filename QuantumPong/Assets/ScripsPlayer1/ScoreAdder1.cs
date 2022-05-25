using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreAdder1 : MonoBehaviour
{
    public TextMeshProUGUI score;
    int PlayerScore1 = 0;
    public bool end = false;
    Vector3 origen = new Vector3 (0, 0, -0.187f);
    public GameObject ball;
    GameObject BallManager;
    BallManager BallmanagerScript;
    void Start()
    {
        BallManager = GameObject.Find("BallManager");
        BallmanagerScript = BallManager.GetComponent<BallManager>();

    }
    void Update()
    {  
       if(PlayerScore1 == 9)
       {
           end = true;
       }
    }
    
    void OnTriggerEnter(Collider other)
    {
       Destroy (other.gameObject);
       PlayerScore1 += 1;
       score.text = PlayerScore1.ToString();
       BallmanagerScript.rightGetPoint = true;
       BallmanagerScript.leftGetPoint = false;


       if(end == false)
       {
            Instantiate(ball, origen, Quaternion.identity);          
       }
    }
}
