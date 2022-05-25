using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
   Vector3 movement = new Vector3 (0, 0.01f, 0);
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(transform.position.y < 2.70f)
            {
                transform.position = transform.position +movement;
            }
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            if(transform.position.y > -2.70f)
            {
                transform.position = transform.position -movement;
            }
        }
    }
    void OnTriggerEnter(Collider ball)
    {
        ball.gameObject.GetComponent<Ball>().speedX *= -1.2f;
    }
}