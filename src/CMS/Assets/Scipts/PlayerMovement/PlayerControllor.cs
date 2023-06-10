using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControllor : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    public float _speed = 3f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void OnMove(InputValue value)
    {
        _rigidbody2D.velocity = value.Get<Vector2>() * _speed;
    }
}
