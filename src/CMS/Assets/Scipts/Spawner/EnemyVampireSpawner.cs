using System.Collections;
using UnityEngine;

public class EnemyVampireSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyVampirePrefabs;

    public float nextAction = 10.0f;
    public float period = 10.1f;


    private void Start()
    {
        InvokeRepeating("SpawnVampire", 45, Random.Range(0,10));
        //var vampireSpawner = GetComponent<EnemyVampireSpawner>()
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
