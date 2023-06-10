using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    //[System.Obsolete]
    //private void Start()
    //{
     //   StartCoroutine(VampireSpawnWait());
    //}

    //private void Update()
   // {
   //     
   // }

   // [System.Obsolete]
   // IEnumerator VampireSpawnWait()
   // {

    //    var vampire = GameObject.Find("EnemyWolfSpawner").GetComponent<EnemyVampireSpawner>();
   //     vampire.enabled = false;

    //    yield return new WaitForSeconds(45);
    //
    //    vampire.enabled = true;
    //}


    public static GameManager gameManager { get; private set; }

    void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
}
