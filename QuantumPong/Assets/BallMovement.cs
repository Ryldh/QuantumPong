using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 Movement;
    public float speed = 5f;
    GameObject BallManager;
    BallManager BallManagerScrip;

    // Start is called before the first frame update
    void Start()
    {
            BallManager = GameObject.Find("BallManager");
            BallManagerScrip = BallManager.GetComponent<BallManager>();
            if(BallManagerScrip.firstRound == true)
            {
                float sx = Random.Range (0, 2) == 0 ? -1 : 1;
                float sy = Random.Range (0, 2) == 0 ? -1 : 1;
                GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
                BallManagerScrip.firstRound = false;
            }
            if(BallManagerScrip.leftGetPoint == true)
                {
                     float sx = 1;
                     float sy = Random.Range (0, 2) == 0 ? -1 : 1;
                    GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
                }
            if(BallManagerScrip.rightGetPoint == true)
            {
                float sx = 1;
                float sy = Random.Range (0, 2) == 0 ? -1 : 1;
                GetComponent<Rigidbody>().velocity = new Vector3(speed * -sx, speed * sy, 0f);
            }
    }

    void Update()
    {
        
    }
    void OnCollisionEnter (Collision collision)
    {
        if(collision.collider.name == "Border" || collision.collider.name == "Border2")
        {

        }

    }
}
