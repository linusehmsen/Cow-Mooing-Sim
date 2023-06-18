using UnityEngine;

public class AIWolfChase : MonoBehaviour
{

    public GameObject cow;
    public float speed;
    public Canvas pauseMenu;
    public Canvas startMenu;

    public Rigidbody2D _rigidbody2D;

    private float distance;


    
    void Update()
    {
        if (pauseMenu.enabled == false || startMenu.enabled == false)
        {
            distance = Vector2.Distance(transform.position, cow.transform.position);
            Vector2 direction = cow.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, cow.transform.position, speed * Time.deltaTime);

            if (cow.activeInHierarchy != true)
            {
                Destroy(gameObject);
            }
        }

        _rigidbody2D.simulated = !pauseMenu.enabled == true;
        //if (pauseMenu.enabled == true)
        //{
        //    _rigidbody2D.simulated = false;
        //}
        //if (pauseMenu.enabled == false)
        //{
        //    _rigidbody2D.simulated = true;
        //}
    }
}