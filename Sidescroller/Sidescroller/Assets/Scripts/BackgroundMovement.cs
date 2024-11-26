using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private GameObject player;
    public GameObject[] backgrounds;
    private float backgroundSize = 18f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject bg in backgrounds)
        {
            if (player.transform.position.x - bg.transform.position.x > backgroundSize * 1.5f)
            {
                float newX = bg.transform.position.x + backgroundSize * 3;
                bg.transform.position = new Vector3(newX, 0f, 0f);
            }

            else if (player.transform.position.x - bg.transform.position.x < -backgroundSize * 1.5f)
            {
                float newX = bg.transform.position.x - backgroundSize * 3;
                bg.transform.position = new Vector3(newX, 0f, 0f);
            }
        }
        
    }
}
