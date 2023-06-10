using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableSpawner : MonoBehaviour
{
    [System.Obsolete]
    private void Start()
    {
        StartCoroutine(VampireSpawnWait());
    }

    private void Update()
    {

    }

    [System.Obsolete]
    IEnumerator VampireSpawnWait()
    {
        var vampireSpawner = GetComponent<EnemyVampireSpawner>();

        vampireSpawner.enabled = false;

        yield return new WaitForSeconds(45);

        vampireSpawner.enabled = true;
    }
}
