using UnityEngine;

public class Animation : MonoBehaviour
{
    public CircleCollider2D circleCollider2D;



    void Update()
    {
        circleCollider2D.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WolfEnemy") || other.CompareTag("VampireEnemy"))
        {
         if(circleCollider2D.enabled == true)
            {
                var WolfhealthComponent = other.GetComponent<EnemyVampireDie>();
                if (WolfhealthComponent != null)
                {
                    WolfhealthComponent.TakeDamage(2.5f);
                }
            }
        }
    }
}
