using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementControllerMB : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D _rigidbody;

    private Vector2 _velocity;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody.linearVelocityX = _velocity.x;
    }

    public void Move(Vector2 direction)
    {
        direction.Normalize();
        _velocity = direction * speed;
        if (direction.x > 0)
            transform.localScale = new(1.0f, 1.0f, 1.0f);
        else if (direction.x < 0)
            transform.localScale = new(-1.0f, 1.0f, 1.0f);
    }
}
