using System;
using System.Collections.Generic;
using UnityEngine;

public class CollectionMB : MonoBehaviour
{
    private readonly HashSet<CollectableItemSO> _collectedItems = new();

    public HashSet<CollectableItemSO> CollectedItems { get => new(_collectedItems); }

    public event Action<CollectableItemSO> OnItemCollected;

    public void CollectItem(CollectableItemSO collectedItem)
    {
        if (_collectedItems.Add(collectedItem))
            OnItemCollected?.Invoke(collectedItem);
    }
}
