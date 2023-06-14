using UnityEngine;

public class AIWolfChase : MonoBehaviour
{

    public GameObject cow;
    public float speed;
    public Canvas pauseMenu;

    public Rigidbody2D _rigidbody2D;

    private float distance;

    
    [System.Obsolete]
    void Update()
    {
        if(pauseMenu.enabled == false)
        {
            distance = Vector2.Distance(transform.position, cow.transform.position);
            Vector2 direction = cow.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, cow.transform.position, speed * Time.deltaTime);

            if (cow.active != true)
            {
                Destroy(gameObject);
            }
        }
        if(pauseMenu.enabled == true)
        {
            _rigidbody2D.simulated = false;
        }
        if (pauseMenu.enabled == false)
        {
            _rigidbody2D.simulated = true;
        }
    }
}
