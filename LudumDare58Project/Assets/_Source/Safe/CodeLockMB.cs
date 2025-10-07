using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CodeLockMB : MonoBehaviour
{
    [SerializeField] private TMP_InputField codeInputField;
    [SerializeField] private Button enterButton;

    [Space]
    [SerializeField] private string correctCode;
    [SerializeField] private UnityEvent OnCorrectCodeEntered;
    [SerializeField] private UnityEvent OnIncorrectCodeEntered;

    private void Awake()
    {
        enterButton.onClick.AddListener(EnterCode);
    }

    public void EnterCode()
    {
        string enteredCode = codeInputField.text;

        if (enteredCode == correctCode)
        {
            OnCorrectCodeEntered.Invoke();
        }
        else
        {
            codeInputField.text = "";
            OnIncorrectCodeEntered.Invoke();
        }
    }
}
