using UnityEngine;

public class DestroySpawner : MonoBehaviour
{
    public GameObject cow;

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if(cow.active != true)
        {
            Destroy(gameObject);
        }
    }
}
