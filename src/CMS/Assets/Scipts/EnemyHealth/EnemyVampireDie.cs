using UnityEngine;

public class EnemyVampireDie : MonoBehaviour
{
    public float health;
    public float maxHealth = 400f;

    //int expAmount = 15;

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
            GameManager.gameManager.ScoreText();
            //ExperienceManager.Instance.AddExperience(expAmount);
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
