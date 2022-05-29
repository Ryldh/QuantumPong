using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float sX = 5;
    public float sY = 5;
    
    GameObject BallManager;
    BallManager BallManagerScript;

    void Start()
    {
        BallManager = GameObject.Find("BallManager");
        BallManagerScript = BallManager.GetComponent<BallManager>();
        
        int initialX = Random.Range(0, 2);
        int initialY = Random.Range(0, 2);

        if(BallManagerScript.firstRound == true)
        {
        if (initialX == 0)
        {
            sX *= -1;
        }
        }
        if (initialY == 0)
        {
            sY *= -1;
        }
       BallManagerScript.firstRound = false;
       
        if(BallManagerScript.leftGetPoint == true)
        {
            sX *= -1;
        }
     }
    
    void Update()
    {
        
        transform.Translate(new Vector3(sX, sY, 0) * Time.deltaTime);
    }
}
