using UnityEngine;

public class EnemyVampireSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyVampirePrefabs;

    public float nextActionTime = 5.0f;
    public float period = 5.1f;


    void Update()
    {
        if (Time.time > nextActionTime)
        {

            nextActionTime += period;
            int randEnemyWolf = Random.Range(0, enemyVampirePrefabs.Length);
            int randSpawnPoint = Random.Range(0, enemyVampirePrefabs.Length);

            Instantiate(enemyVampirePrefabs[randEnemyWolf], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
        if (enemyVampirePrefabs[0] == null)
        {
            Destroy(gameObject);
        }
    }
}
