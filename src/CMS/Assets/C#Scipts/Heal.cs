using UnityEngine;

public class Heal : MonoBehaviour
{
    public Health playerHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var healthComponent = other.GetComponent<Health>();
            healthComponent.Heal(5);
        }
    }
}
