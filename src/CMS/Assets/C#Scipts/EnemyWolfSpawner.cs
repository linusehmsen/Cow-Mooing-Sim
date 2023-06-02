using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyWolfPrefabs;

    private float nextActionTime = 4.0f;
    public float period = 4.1f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {

            nextActionTime += period;
            int randEnemy = Random.Range(0, enemyWolfPrefabs.Length);
            int randSpawnPoint = Random.Range(0, enemyWolfPrefabs.Length);

            Instantiate(enemyWolfPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
