using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    private float scale = 1f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, moveY, 0f);
        transform.Translate(move * speed * Time.deltaTime);
        scale += 1f * Time.deltaTime;
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            scale = 0.5f;
            collision.gameObject.GetComponent<EnemyMovement>().Die();
        }
        else if(collision.gameObject.CompareTag("Powerup"))
        {
            gameObject.transform.localScale = new Vector3(2f, 2f, 2f);
        }
    }


}
