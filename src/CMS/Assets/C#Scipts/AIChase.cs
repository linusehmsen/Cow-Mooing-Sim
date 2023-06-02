using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{

    public GameObject cow;
    public float speed;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, cow.transform.position);
        Vector2 direction = cow.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, cow.transform.position, speed * Time.deltaTime);
    }
}
