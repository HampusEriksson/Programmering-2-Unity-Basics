using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", spawnDelay);
    }

    void SpawnEnemy()
    {

        Instantiate(enemyPrefab, GetPosition(), enemyPrefab.transform.rotation);
        spawnDelay -= 0.1f;
        if (spawnDelay <= 0.1f)
        {
            spawnDelay = 0.1f;
        }
        Invoke("SpawnEnemy", spawnDelay);
    }

    private Vector3 GetPosition()
    {
        if (UnityEngine.Random.Range(0f,1f) < 0.5f)
        {
            return new Vector3(UnityEngine.Random.Range(-8, 8), 5);
        }
        else
        {
            return new Vector3(UnityEngine.Random.Range(-8, 8), -5);
        }
    }
}
