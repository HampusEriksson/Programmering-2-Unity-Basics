using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private int direction = 1;
    private float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(direction, 0, 0);
        transform.Translate(move * speed * Time.deltaTime);

        if(Math.Abs(transform.position.x) >= 10)
        {
            direction *= -1;
        }
    }
}
