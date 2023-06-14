using UnityEngine;

public class HealthPackageSpawner : MonoBehaviour
{
    public GameObject[] healthPackagePrefabs;

    public Canvas pauseMenu;


    private void Start()
    {
        InvokeRepeating("SpawnHealthPackages", Random.Range(0,20), Random.Range(0, 20));
    }
    Vector3 getRandomPosition()
    {
        float _x = Random.Range(-10, 9);
        float _y = Random.Range(-4, 4);
        float _z = Random.Range(0, 0);

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }

    void SpawnHealthPackages()
    {
        if(pauseMenu.enabled == false)
        {
            Instantiate(healthPackagePrefabs[0], getRandomPosition(), Quaternion.identity);
        }
    }
}
