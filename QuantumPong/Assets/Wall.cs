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

    void OnTriggerEnter(Collider Ball)
    {
        // Cambiar dirección de la bola
        Ball.gameObject.GetComponent<Ball>().speedY *= -1;
    }
}
