using UnityEngine;

public class HealthPackageSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] healthPackagePrefabs;



    public float nextActionTime = 20.0f;
    public float period = 20.1f;

    public void Start()
    {
        
    }
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
