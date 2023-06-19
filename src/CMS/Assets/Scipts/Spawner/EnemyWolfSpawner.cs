using UnityEngine;

public class EnemyWolfSpawner : MonoBehaviour
{
    public GameObject[] enemyWolfPrefabs;

    public Canvas pauseMenu;


    private void Start()
    {
        InvokeRepeating("SpawnWolf", 1, Random.Range(3,8));
    }

    void Update()
    {
        DeleteSpawner();
    }

    void DeleteSpawner()
    {
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

    Vector3 getRandomPosition()
    {
        float _x = Random.Range(-10, 9);
        float _y = Random.Range(-4, 4);
        float _z = Random.Range(0, 0);

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }

    void SpawnWolf()
    {
        if(pauseMenu.enabled == false)
        {
            Instantiate(enemyWolfPrefabs[Random.Range(0, 2)], getRandomPosition(), Quaternion.identity);
        }
    }
}
