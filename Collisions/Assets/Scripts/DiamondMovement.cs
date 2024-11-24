using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiamondMovement : EnemyMovement
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        player = GameObject.Find("Player");
    }
    public override void Move()
    {
        // Sätt 1
        Vector3 move = (player.transform.position - transform.position).normalized;
        transform.Translate(move * speed * Time.deltaTime);

        // Sätt 2
        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
