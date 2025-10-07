using UnityEngine;
using UnityEngine.UI;

public class CollectableItemViewDisplayerMB : MonoBehaviour
{
    [SerializeField] private Image viewImage;
    [SerializeField] private Button hideViewButton;

    private void Start()
    {
        hideViewButton.onClick.AddListener(HideCollectableItem);
        HideCollectableItem();
    }

    public void DisplayCollectableItem(CollectableItemSO collectableItem)
    {
        viewImage.sprite = collectableItem.Icon;
        gameObject.SetActive(true);
    }

    public void HideCollectableItem()
    {
        viewImage.sprite = null;
        gameObject.SetActive(false);
    }
}
