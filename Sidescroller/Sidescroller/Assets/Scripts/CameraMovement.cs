using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float newX = player.transform.position.x + 3f;

        if (newX < -16f)
        {
            newX = -16f;
        }

        transform.position = new Vector3(newX, 0, -10f);
        
    }
}
