using UnityEngine;

public class WolfDie : MonoBehaviour
{
    public float health;
    public float maxHealth = 400f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
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
