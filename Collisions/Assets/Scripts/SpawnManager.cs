using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private float spawnDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 0.5f);
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, enemies.Length);
        Instantiate(enemies[index], GetRandomSpawnPoint(), enemies[index].transform.rotation);
        spawnDelay *= 0.5f;

        // Samma som if nedan
        Mathf.Clamp(spawnDelay, 0.2f, spawnDelay);

        // Samma som Clamp ovan
        if (spawnDelay < 0.2f)
        {
            spawnDelay = 0.2f;
        }

        Invoke("SpawnEnemy", spawnDelay);
    }

    private Vector3 GetRandomSpawnPoint()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-5f, 5f);

        return new Vector3(x, y, 0);
    }
}
