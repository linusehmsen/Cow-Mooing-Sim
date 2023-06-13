using System.Collections;
using UnityEngine;

public class EnemyVampireSpawner : MonoBehaviour
{
    public GameObject[] enemyVampirePrefabs;


    private void Start()
    {
        InvokeRepeating("SpawnVampire", 45, Random.Range(0,15));
    }

    [System.Obsolete]
    void Update()
    {
        DeleteSpawner();
    }

    void DeleteSpawner()
    {
        if (enemyVampirePrefabs[0] == null)
        {
            Destroy(gameObject);
        }
    }

    Vector3 getRandomPosition()
    {
        float _x = Random.Range(-10, 9);
        float _y = Random.Range(-4, 4);
        float _z = Random.Range(0, 0);

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }

    void SpawnVampire()
    {
        Instantiate(enemyVampirePrefabs[Random.Range(0,2)], getRandomPosition(), Quaternion.identity);
    }
}
