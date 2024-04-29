using Buttons;
using TMPro;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI balloon;
    protected abstract string HelloText { get; }

    private void Hello()
    {
        print(HelloText);
        //balloon.text = HelloText;
        //balloon.gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        ButtonManager.GetButton(ButtonType.Hello).onClick.AddListener(Hello);
    }

    private void OnDisable()
    {
        ButtonManager.GetButton(ButtonType.Hello).onClick.RemoveListener(Hello);
    }
}