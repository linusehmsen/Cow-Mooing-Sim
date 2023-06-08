using UnityEngine;

public class EnemyWolfSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyWolfPrefabs;

    public float nextActionTime = 4.0f;
    public float period = 4.1f;

   
    void Update()
    {
        if (Time.time > nextActionTime)
        {

            nextActionTime += period;
            int randEnemyWolf = Random.Range(0, enemyWolfPrefabs.Length);
            int randSpawnPoint = Random.Range(0, enemyWolfPrefabs.Length);

            Instantiate(enemyWolfPrefabs[randEnemyWolf], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
        if (enemyWolfPrefabs[0] == null)
        {
            Destroy(gameObject);
        }
        if (enemyWolfPrefabs[1] == null)
        {
            Destroy(gameObject);
        }
        if (enemyWolfPrefabs[2] == null)
        {
            Destroy(gameObject);
        }
    }
}
