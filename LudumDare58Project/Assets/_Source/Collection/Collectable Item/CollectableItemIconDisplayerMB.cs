using UnityEngine;
using UnityEngine.UI;

public class CollectableItemIconDisplayerMB : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private Button showViewButton;

    private CollectableItemViewDisplayerMB _collectableItemViewDisplayer;
    
    private CollectableItemSO _collectableItem;

    private void Awake()
    {
        showViewButton.onClick.AddListener(ShowView);
    }

    public void DisplayCollectableItem(CollectableItemSO collectableItem, CollectableItemViewDisplayerMB collectableItemViewDisplayer)
    {
        _collectableItem = collectableItem;
        _collectableItemViewDisplayer = collectableItemViewDisplayer;
        iconImage.sprite = _collectableItem.Icon;
    }

    private void ShowView()
    {
        _collectableItemViewDisplayer.DisplayCollectableItem(_collectableItem);
    }
}
