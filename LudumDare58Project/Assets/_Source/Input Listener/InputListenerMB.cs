using UnityEngine;
using UnityEngine.InputSystem;

public class InputListenerMB : MonoBehaviour
{
    [SerializeField] private MovementControllerMB movementController;
    [SerializeField] private InteractionController interactionController;

    public void OnMove(InputValue value)
    {
        OnMoveInput(value.Get<Vector2>());
    }

    public void OnInteract(InputValue value)
    {
        OnInteractInput(value.isPressed);
    }

    private void OnMoveInput(Vector2 input)
    {
        movementController.Move(input);
    }

    private void OnInteractInput(bool interact)
    {
        if (interact)
            interactionController.Interact();
    }
}
