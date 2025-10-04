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
        _velocity = direction.normalized * speed;
    }
}
