using Buttons;
using TMPro;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private GameObject balloon;
    private TextMeshProUGUI text;

    protected abstract string HelloText { get; }

    private void Hello()
    {
        text.text = HelloText;
        balloon.SetActive(true);
    }

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>(true);
        balloon = text.transform.parent.gameObject;
    }

    private void OnEnable() => ButtonManager.GetButton(ButtonType.Hello).onClick.AddListener(Hello);
    private void OnDisable() => ButtonManager.GetButton(ButtonType.Hello).onClick.RemoveListener(Hello);
}