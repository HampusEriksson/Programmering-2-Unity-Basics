using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 direction;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 playerPosition = GameObject.Find("Player").transform.position;
        direction = (playerPosition - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
