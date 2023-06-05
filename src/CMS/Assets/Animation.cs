using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public CircleCollider2D circleCollider2D;
    
    
    private Animator myAnimator;
    private bool attack;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        circleCollider2D.enabled = false ;
    }

    private void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        HandleAttacks();

        ResetValues();
    }

    private void HandleAttacks()
    {
        if (attack)
        {
            myAnimator.SetTrigger("KillStuff");
        }
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack = true;
        }
    }

    void ResetValues()
    {
        attack = false;
    }
}
