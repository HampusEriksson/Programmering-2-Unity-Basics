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

        Vector3 move = new Vector3(moveX, 0f, 0f);
        transform.Translate(move * speed * Time.deltaTime * Settings.gameSpeed);

        if (transform.position.x < -26f)
        {
            transform.position = new Vector3(-26f, 0f, -0.1f);
        }
    }

  


}