using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, moveY, 0f);
        transform.Translate(move * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else if(collision.gameObject.CompareTag("Powerup"))
        {
            gameObject.transform.localScale = new Vector3(2f, 2f, 2f);
        }
    }


}
