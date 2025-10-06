using UnityEngine;
using UnityEngine.Events;

public class CollectionReviewerMB : MonoBehaviour
{
    [SerializeField] private CollectableItemSO[] requiredItems = new CollectableItemSO[0];
    [Space]
    [SerializeField] private UnityEvent OnCollectionSucessfullyReviewed;
 [SerializeField] private UnityEvent OnCollectionUnsucessfullyReviewed;

    public void ReviewCollection(CollectionMB reviewedCollection)
    {
        foreach (var collectableItem in requiredItems)
            if (!reviewedCollection.CollectedItems.Contains(collectableItem)){
 OnCollectionUnsucessfullyReviewed.Invoke();
                return;
            }
        OnCollectionSucessfullyReviewed.Invoke();
    }
}
