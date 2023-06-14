using UnityEngine;

public class DestroySpawner : MonoBehaviour
{
    public GameObject cow;

    [System.Obsolete]
    void Update()
    {
        if (cow.active != true)
        {
            Destroy(gameObject);
        }
    }
}
