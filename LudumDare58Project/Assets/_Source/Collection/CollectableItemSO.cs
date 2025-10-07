using UnityEngine;

[CreateAssetMenu(fileName = "CollectableObject", menuName = "Scriptable Objects/CollectableObject")]
public class CollectableItemSO : ScriptableObject
{
    [SerializeField] private Sprite icon;

    public Sprite Icon { get => icon; }
}
