using UnityEngine;

public class HealthPackageSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] healthPackagePrefabs;

    public float nextActionTime = 25.0f;
    public float period = 25.1f;
    

    void Update()
    {
        if (Time.time > nextActionTime)
        {

            nextActionTime += period;
            int randHealthPackages = Random.Range(0, healthPackagePrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(healthPackagePrefabs[randHealthPackages], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
