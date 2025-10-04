using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CutsceneController_MB : MonoBehaviour
{
    [SerializeField] private CutsceneAction[] cutsceneActions = new CutsceneAction[0];

    private Coroutine _playingCutscene;

    private void Start()
    {
        StartCutscene();
    }

    public void StartCutscene()
    {
        if (_playingCutscene != null)
            return;

        _playingCutscene = StartCoroutine(PlayingCutscene());
    }

    private IEnumerator PlayingCutscene()
    {
        int i = 0;

        while (i < cutsceneActions.Length)
        {
            cutsceneActions[i].UnityEvent.Invoke();
            yield return new WaitForSeconds(cutsceneActions[i].NextActionDelay);
            i++;
        }

        _playingCutscene = null;
    }

    [Serializable]
    private class CutsceneAction
    {
        [SerializeField] private UnityEvent unityEvent = new();
        [SerializeField] private float nextActionDelay;

        public UnityEvent UnityEvent { get => unityEvent; }
        public float NextActionDelay { get => nextActionDelay; }
    }
}
