using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    public float speed;

    public abstract void Move();

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
