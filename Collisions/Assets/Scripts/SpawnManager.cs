using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, 3f);
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, GetRandomSpawnPoint(), enemy.transform.rotation);
    }

    private Vector3 GetRandomSpawnPoint()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-5f, 5f);

        return new Vector3(x, y, 0);
    }
}
