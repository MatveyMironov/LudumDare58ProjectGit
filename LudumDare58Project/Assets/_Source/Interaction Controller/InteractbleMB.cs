using UnityEngine;
using UnityEngine.Events;

public class InteractbleMB : MonoBehaviour
{
    [SerializeField] private GameObject interactionIndicator;
    [SerializeField] private UnityEvent OnInteraction;

    public void ShowInteraction()
    {
        interactionIndicator.SetActive(true);
    }

    public void HideInteraction()
    {
        interactionIndicator.SetActive(false);
    }

    public void Interact()
    {
        OnInteraction.Invoke();
    }
}
