using System.Collections;
using UnityEngine;

public class EnableDisableSpawner : MonoBehaviour
{
    public GameObject Vampire;
    public GameObject VampireSpawner;



    [System.Obsolete]
    private void Start()
    {
        //StartCoroutine(VampireSpawnWait());
    }

    private void Update()
    {

    }

    [System.Obsolete]
    IEnumerator VampireSpawnWait()
    {
        VampireSpawner.active = false;
        Vampire.active = false;

        yield return new WaitForSeconds(45);

        VampireSpawner.active = true;
        Vampire.active = true;
    }
}
