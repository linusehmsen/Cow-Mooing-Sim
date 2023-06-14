using UnityEngine;

public class Animation : MonoBehaviour
{
    public CircleCollider2D circleCollider2D;
    public Canvas pauseMenu;



    void Update()
    {
        circleCollider2D.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(pauseMenu.enabled == false)
        {
            if (other.CompareTag("WolfEnemy") || other.CompareTag("VampireEnemy"))
            {
                if (circleCollider2D.enabled == true)
                {
                    var WolfhealthComponent = other.GetComponent<EnemyVampireDie>();
                    if (WolfhealthComponent != null)
                    {
                        WolfhealthComponent.TakeDamage(1.5f);
                    }
                }
            }
        }
    }
}
