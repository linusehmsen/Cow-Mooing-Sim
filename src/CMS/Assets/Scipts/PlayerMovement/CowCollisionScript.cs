using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowCollisionScript : MonoBehaviour
{
    public Canvas pauseMenu;

    private void Update()
    {
        RigidBodyStuff();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(pauseMenu.enabled == false)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Rigidbody rbdy = collision.gameObject.GetComponent<Rigidbody>();

                rbdy.velocity = Vector3.zero;

                rbdy.angularVelocity = Vector3.zero;
            }
        }
    }


    private void RigidBodyStuff()
    {
        if(pauseMenu.enabled == false)
        {
            var _rigidBody2D = GetComponent<Rigidbody2D>();
            _rigidBody2D.simulated = true;
        }
        if (pauseMenu.enabled == true)
        {
            var _rigidBody2D = GetComponent<Rigidbody2D>();
            _rigidBody2D.simulated = false;
        }
    }
}
