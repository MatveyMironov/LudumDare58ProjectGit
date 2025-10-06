using System;
using UnityEngine;

public class CounterMB : MonoBehaviour
{
    [SerializeField] private int correctCount;

    int _count = 0;

    public bool IsCountCorrect { get => _count == correctCount; }

    public event Action OnCorrectCountReached;
    public event Action OnCorrectCountExceeded;

    public void Count()
    {
        _count++;
        if (_count == correctCount)
            OnCorrectCountReached?.Invoke();
        else if (_count > correctCount)
            OnCorrectCountExceeded?.Invoke();
    }

    public void Reset()
    {
        _count = 0;
    }
}
