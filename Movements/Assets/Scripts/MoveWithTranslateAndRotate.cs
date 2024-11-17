using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveWithTranslateAndRotate : MonoBehaviour
{
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, moveY, 0f);

        //Antingen denna rad kod för att röra spelaren
        //transform.Translate(move * speed * Time.deltaTime, Space.World);


        if(move.magnitude > 0f)
        {
            float angle = Mathf.Atan2(move.y, move.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

            //Eller denna rad kod för att röra spelaren
            transform.Translate(transform.right * speed * Time.deltaTime, Space.World);
        }

    }
}
