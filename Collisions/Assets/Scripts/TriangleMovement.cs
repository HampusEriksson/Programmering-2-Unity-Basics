using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMovement : EnemyMovement
{
    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }
    public override void Move()
    {       
        Vector3 move = new Vector3(direction, 0, 0);
        transform.Translate(move* speed * Time.deltaTime);

        if(Math.Abs(transform.position.x) >= 10)
        {
            direction *= -1;
        }
    }

    
}
