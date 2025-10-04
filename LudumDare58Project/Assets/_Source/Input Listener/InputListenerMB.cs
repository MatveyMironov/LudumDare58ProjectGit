using UnityEngine;
using UnityEngine.InputSystem;

public class InputListenerMB : MonoBehaviour
{
    [SerializeField] private MovementControllerMB movementController;

    public void OnMove(InputValue value)
    {
        OnMoveInput(value.Get<Vector2>());
    }

    private void OnMoveInput(Vector2 input)
    {
        movementController.Move(input);
    }
}
