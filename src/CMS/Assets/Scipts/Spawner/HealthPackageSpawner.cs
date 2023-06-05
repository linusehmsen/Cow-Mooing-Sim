using UnityEngine;

public class HealthPackageSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] healthPackagePrefabs;

    

    private float nextActionTime = 15.0f;
    public float period = 9.1f;

    public float randomTimer;

    private void Start()
    {
        randomTimer = Random.Range(14f, 37f);
    }
    public void Update()
    {
        if (Time.time > nextActionTime)
        {
            //nextActionTime += period;
            randomTimer += Time.deltaTime;

            int randHealthPackage = Random.Range(0, healthPackagePrefabs.Length);
            int randSpawnPoint = Random.Range(0, healthPackagePrefabs.Length);

            Instantiate(healthPackagePrefabs[randHealthPackage], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
