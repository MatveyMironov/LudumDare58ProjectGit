using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    [SerializeField] private float interactionRadius;
    [SerializeField] private LayerMask interactableLayers;

    private readonly HashSet<InteractbleMB> _availableInteractions = new();

    private void Update()
    {
        HashSet<InteractbleMB> foundInteractions = new();
        var colliders = Physics2D.OverlapCircleAll(transform.position, interactionRadius, interactableLayers);
        foreach (var collider in colliders)
            if (collider.TryGetComponent(out InteractbleMB interactable))
            {
                foundInteractions.Add(interactable);
                interactable.ShowInteraction();
            }

        foreach (var interactable in _availableInteractions)
            if (!foundInteractions.Contains(interactable))
                interactable.HideInteraction();

        _availableInteractions.Clear();
        _availableInteractions.AddRange(foundInteractions);
    }

    public void Interact()
    {
        foreach (var interactable in _availableInteractions)
            interactable.Interact();
    }
}
