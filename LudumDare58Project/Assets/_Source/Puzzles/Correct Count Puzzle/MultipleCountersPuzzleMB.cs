using UnityEngine;
using UnityEngine.Events;

public class MultipleCountersPuzzleMB : MonoBehaviour
{
    [SerializeField] private CounterMB[] counters = new CounterMB[0];

    [SerializeField] private UnityEvent OnMistakeMade;
    [SerializeField] private UnityEvent OnPuzzleSolved;

    private void Start()
    {
        foreach (var counter in counters)
        {
            counter.OnCorrectCountExceeded += ResetAllCounters;
            counter.OnCorrectCountReached += CheckAllCounters;
        }
    }

    private void ResetAllCounters()
    {
        foreach(var counter in counters)
            counter.Reset();
        OnMistakeMade?.Invoke();
    }

    private void CheckAllCounters()
    {
        foreach (var counter in counters)
        {
            if (!counter.IsCountCorrect)
                return;
        }

        OnPuzzleSolved?.Invoke();
    }
}
