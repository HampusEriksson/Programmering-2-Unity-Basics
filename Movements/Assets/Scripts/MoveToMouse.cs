using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {

        // Hitta musens position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        // Beräkna riktningen mot musen
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Flytta spelaren
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        // Rotera
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

    }
}
