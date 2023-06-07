using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject cow;

    public float maxHealth = 20;
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    [Obsolete]
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            cow.active = false;
            Debug.Log("Destroy Da ko Complete");
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

}
