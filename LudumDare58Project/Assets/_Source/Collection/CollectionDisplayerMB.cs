using UnityEngine;

public class CollectionDisplayerMB : MonoBehaviour
{
    [SerializeField] private CollectionMB displayedCollection;
    [SerializeField] private CollectableItemIconDisplayerMB collectableItemDisplayerPrefab;
    [SerializeField] private RectTransform collectableItemDisplayersRoot;
    [SerializeField] private CollectableItemViewDisplayerMB collectableItemViewDisplayerPrefab;

    private void Start()
    {
        displayedCollection.OnItemCollected += DisplayItemCollected;
        DisplayCollectedItems();
    }

    private void DisplayItemCollected(CollectableItemSO collectedItem)
    {
        var collectableItemDisplayer = Instantiate(collectableItemDisplayerPrefab, collectableItemDisplayersRoot);
        collectableItemDisplayer.DisplayCollectableItem(collectedItem, collectableItemViewDisplayerPrefab);
    }

    private void DisplayCollectedItems()
    {
        foreach (var collectedItem in displayedCollection.CollectedItems)
            DisplayItemCollected(collectedItem);
    }
}
