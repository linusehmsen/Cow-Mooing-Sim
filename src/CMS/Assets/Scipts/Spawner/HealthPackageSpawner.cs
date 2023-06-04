using UnityEngine;

public class HealthPackageSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] healthPackagePrefabs;

    private float nextActionTime = 9.0f;
    public float period = 9.1f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {

            nextActionTime += period;
            int randHealthPackage = Random.Range(0, healthPackagePrefabs.Length);
            int randSpawnPoint = Random.Range(0, healthPackagePrefabs.Length);

            Instantiate(healthPackagePrefabs[randHealthPackage], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
