using UnityEngine;
using UnityEngine.Events;

public class InteractbleMB : MonoBehaviour
{
    [SerializeField] private GameObject interactionIndicator;
    [SerializeField] private UnityEvent OnInteraction;

    public void ShowInteraction()
    {
        if (!isActiveAndEnabled)
            return;
        interactionIndicator.SetActive(true);
    }

    public void HideInteraction()
    {
        if (!isActiveAndEnabled)
            return;
        interactionIndicator.SetActive(false);
    }

    public void Interact()
    {
        if (!isActiveAndEnabled)
            return;
        OnInteraction.Invoke();
    }
}
