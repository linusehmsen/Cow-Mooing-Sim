using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public float health;
    public float maxHealth = 200f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(float damageAmount)
    {
        health += damageAmount;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
