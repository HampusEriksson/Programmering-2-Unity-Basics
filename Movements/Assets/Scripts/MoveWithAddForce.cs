using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithAddForce : MonoBehaviour
{
    private float force = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(moveX, moveY);
        rb.AddForce(move * force * Time.deltaTime);

    }
}
