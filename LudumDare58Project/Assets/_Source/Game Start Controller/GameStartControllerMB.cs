using UnityEngine;
using UnityEngine.Events;

public class GameStartControllerMB : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameStart;

    private void Start()
    {
        OnGameStart?.Invoke();
    }
}
