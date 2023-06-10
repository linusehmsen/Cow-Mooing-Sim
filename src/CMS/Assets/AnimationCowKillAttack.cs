using UnityEngine;

public class AnimationCowKillAttack : MonoBehaviour
{
    bool CowAttack;
    Animator myAnimator;
    public CircleCollider2D _circleCollider2D;

    void Start()
    {
        _circleCollider2D.enabled = false;
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        HandleAttacks();

        ResetValues();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CowAttack = true;
        }
    }

    void HandleAttacks()
    {
        if (CowAttack)
        {
            myAnimator.SetTrigger("CowAttack");
        }
    }

    void ResetValues()
    {
        CowAttack = false;
    }
}
