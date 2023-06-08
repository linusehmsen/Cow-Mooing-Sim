using System.Collections;
using UnityEngine;

public class EnemyVampireSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyVampirePrefabs;

    public float nextActionTime = 5.0f;
    public float period = 5.1f;


    
    void Update()
    {
        StartCoroutine(VampireSpawnTime());
        
        StopCoroutine(VampireSpawnTime());
        
        
        if (Time.time > nextActionTime)
        {

            nextActionTime += period;
            int randEnemyVampire = Random.Range(0, enemyVampirePrefabs.Length);
            int randSpawnPoint = Random.Range(0, enemyVampirePrefabs.Length);

            Instantiate(enemyVampirePrefabs[randEnemyVampire], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
        if (enemyVampirePrefabs[0] == null)
        {
            Destroy(gameObject);
        }
        if (enemyVampirePrefabs[1] == null)
        {
            Destroy(gameObject);
        }
        if (enemyVampirePrefabs[2] == null)
        {
            Destroy(gameObject);
        }
    }


    IEnumerator VampireSpawnTime()
    {
        yield return new WaitForSeconds(45);
        if (Time.time > 0)
        {

            nextActionTime += period;
            int randEnemyVampire = Random.Range(0, enemyVampirePrefabs.Length);
            int randSpawnPoint = Random.Range(0, enemyVampirePrefabs.Length);

            Instantiate(enemyVampirePrefabs[randEnemyVampire], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
        if (enemyVampirePrefabs[0] == null)
        {
            Destroy(gameObject);
        }
        if (enemyVampirePrefabs[1] == null)
        {
            Destroy(gameObject);
        }
        if (enemyVampirePrefabs[2] == null)
        {
            Destroy(gameObject);
        }
    }
}
