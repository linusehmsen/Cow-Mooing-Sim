using UnityEngine;

public class AIWolfChase : MonoBehaviour
{

    public GameObject cow;
    public float speed;

    private float distance;

    
    [System.Obsolete]
    void Update()
    {
        distance = Vector2.Distance(transform.position, cow.transform.position);
        Vector2 direction = cow.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, cow.transform.position, speed * Time.deltaTime);

        if (cow.active != true)
        {
            Destroy(gameObject);
        }
    }
}
