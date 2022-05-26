using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider ball)
    {
        ball.gameObject.GetComponent<Ball>().sY *= -1;
    }
}
