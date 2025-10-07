using UnityEngine;
using UnityEngine.UI;

public class CollectionDisplayerMB : MonoBehaviour
{
    [SerializeField] private CollectionMB displayedCollection;
    [SerializeField] private Image collectedItemIconImagePrefab;
    [SerializeField] private RectTransform collectedItemIconImagesRoot;

    private void Start()
    {
        displayedCollection.OnItemCollected += DisplayItemCollected;
        DisplayCollectedItems();
    }

    private void DisplayItemCollected(CollectableItemSO collectedItem)
    {
        Instantiate(collectedItemIconImagePrefab, collectedItemIconImagesRoot).sprite = collectedItem.Icon;
    }

    private void DisplayCollectedItems()
    {
        foreach (var collectedItem in displayedCollection.CollectedItems)
            DisplayItemCollected(collectedItem);
    }
}
