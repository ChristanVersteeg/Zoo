using Buttons;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using static Constants;

public abstract class Animal : MonoBehaviour
{
    private GameObject balloon;
    private TextMeshProUGUI text;

    protected abstract string Text { get; }
    protected virtual ButtonType ButtonType => ButtonType.Hello;

    [SuppressMessage(Category, CheckId, Justification = Justification)]
    protected void AddBehavior<T>(T diet) where T : MonoBehaviour => gameObject.AddComponent<T>();

    protected virtual void Speak()
    {
        text.text = Text;
        balloon.SetActive(true);
    }

    protected virtual void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>(true);
        balloon = text.transform.parent.gameObject;
    }

    private void OnEnable() => ButtonManager.GetButton(ButtonType).onClick.AddListener(Speak);
    private void OnDisable() => ButtonManager.GetButton(ButtonType).onClick.RemoveListener(Speak);
}