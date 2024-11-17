using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithTranslate : MonoBehaviour
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
}
