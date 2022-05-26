using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float sX = 3;
    public float sY = 3;
    public bool firstRound = true;

    void Start()
    {
        int initialX = Random.Range(0, 2);
        int initialY = Random.Range(0, 2);
     
        if (initialX == 0)
        {
            sX *= -1;
        }
        if (initialY == 0)
        {
            sY *= -1;
        }
        firstRound = false;
     }
    
    void Update()
    {
        
        transform.Translate(new Vector3(sX, sY, 0) * Time.deltaTime);
    }
}
