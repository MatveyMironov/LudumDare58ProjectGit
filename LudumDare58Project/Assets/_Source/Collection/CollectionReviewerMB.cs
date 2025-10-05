using UnityEngine;
using UnityEngine.Events;

public class CollectionReviewerMB : MonoBehaviour
{
    [SerializeField] private CollectableItemSO[] requiredItems = new CollectableItemSO[0];
    [Space]
    [SerializeField] private UnityEvent OnCollectionSucessfullyReviewed;

    public void ReviewCollection(CollectionMB reviewedCollection)
    {
        foreach (var collectableItem in requiredItems)
            if (!reviewedCollection.CollectedItems.Contains(collectableItem))
                return;

        OnCollectionSucessfullyReviewed.Invoke();
    }
}
