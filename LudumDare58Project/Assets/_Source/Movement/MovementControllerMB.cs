using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementControllerMB : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private Vector2 _velocity;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        _rigidbody.linearVelocityX = _velocity.x;
    }

    public void Move(Vector2 direction)
    {
        direction.y = 0.0f;
        direction.Normalize();
        _velocity = direction * speed;

        if (_velocity.x != 0.0f)
            _animator.SetBool("IsMoving", true);
        else
            _animator.SetBool("IsMoving", false);

        if (direction.x > 0)
            transform.localScale = new(1.0f, 1.0f, 1.0f);
        else if (direction.x < 0)
            transform.localScale = new(-1.0f, 1.0f, 1.0f);
    }
}
