using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public CircleCollider2D circleCollider2D;
    
    
    private Animator myAnimator;
    private bool attack;

    private void Start()
    {

    }

    public void CircleCollider2dEnabled()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            circleCollider2D.enabled = true;
            Debug.Log("circleCollider2D.enabled = true;" + "done");
        }
    }
    
    [Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WolfEnemy"))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var WolfhealthComponent = other.GetComponent<EnemyDie>();
                if (WolfhealthComponent != null)
                {
                    WolfhealthComponent.TakeDamage(1);
                }
            }
        }
    }
}
