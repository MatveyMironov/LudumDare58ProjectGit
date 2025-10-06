using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FragmentPlacementMB : MonoBehaviour
{
    [SerializeField] private RectTransform[] fragments = new RectTransform[0];
    [SerializeField] private RectTransform[] placments = new RectTransform[0];

    [SerializeField] private UnityEvent OnPuzzleSolved;

    private readonly Dictionary<int, int> fragmentPlacements = new();

    private int _selectedFragmentIndex;

    public void SelectFragment(int index)
    {
        if (index < 0 || index >= fragments.Length)
            return;

        _selectedFragmentIndex = index;
    }

    public void PlaceFragment(int index)
    {
        if (index < 0 || index >= placments.Length)
            return;

        fragments[_selectedFragmentIndex].position = placments[index].position;
        fragmentPlacements[_selectedFragmentIndex] = index;

        CheckIfAllPlacedCorrectly();
    }

    private void CheckIfAllPlacedCorrectly()
    {
        for (int fragmentIndex = 0; fragmentIndex < fragments.Length; fragmentIndex++)
        {
            if (fragmentIndex != fragmentPlacements[fragmentIndex])
            {
                return;
            }
        }
        
        OnPuzzleSolved?.Invoke();
    }
}
