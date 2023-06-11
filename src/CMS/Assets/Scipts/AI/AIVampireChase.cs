using UnityEngine;

public class AIVampireChase : MonoBehaviour
{

    public GameObject cow;
    public float speed;

    


    [System.Obsolete]
    void Update()
    {
        float distance = Vector2.Distance(transform.position, cow.transform.position);
        
        Vector2 direction = cow.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, cow.transform.position, speed * Time.deltaTime);

        if (cow.active != true)
        {
            Destroy(gameObject);
        }
    }
}
