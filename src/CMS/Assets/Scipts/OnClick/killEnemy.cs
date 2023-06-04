using System;
using UnityEngine;

public class killEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    public Collider2D KillCollder;

    private void Start()
    {
        KillCollder.enabled = false;
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            KillCollder.enabled = false;
        }
    }
}
