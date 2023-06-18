using UnityEngine;

public class KillCow : MonoBehaviour
{
    public CircleCollider2D _circleCollider2D;
    public Canvas pauseMenu;

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(pauseMenu.enabled == false)
        {
            if (other.CompareTag("Player"))
            {
                if (other != _circleCollider2D)
                {
                    var healthComponent = other.GetComponent<Health>();
                    if (healthComponent != null)
                    {
                        healthComponent.TakeDamage(1.5f);
                    }
                }
            }
        }
    }
}
