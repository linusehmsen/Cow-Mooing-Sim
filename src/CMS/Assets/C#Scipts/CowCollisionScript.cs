using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowCollisionScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rbdy = collision.gameObject.GetComponent<Rigidbody>();
            
            rbdy.velocity = Vector3.zero;
            
            rbdy.angularVelocity = Vector3.zero;
        }
    }
}
