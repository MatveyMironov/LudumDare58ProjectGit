using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CorrectSelectionPuzzleMB : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Sprite[] sprites = new Sprite[0];
    [SerializeField] private int correctIndex;
    [SerializeField] private UnityEvent OnCorrectGuessMade;
    [SerializeField] private UnityEvent OnIncorrectGuessMade;

    int _selectedIndex = 0;

    private void Start()
    {
        image.sprite = sprites[_selectedIndex];
    }

    public void Next()
    {
        _selectedIndex++;
        if (_selectedIndex >= sprites.Length)
            _selectedIndex = 0;
        image.sprite = sprites[_selectedIndex];
    }

    public void Previous()
    {
        _selectedIndex--;
        if (_selectedIndex < 0)
            _selectedIndex = sprites.Length - 1;
        image.sprite = sprites[_selectedIndex];
    }

    public void Check()
    {
        if (_selectedIndex == correctIndex)
            OnCorrectGuessMade?.Invoke();
        else
            OnIncorrectGuessMade?.Invoke();
    }
}
