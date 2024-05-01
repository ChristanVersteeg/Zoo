using Buttons;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using static Constants;

public abstract class Animal : MonoBehaviour
{
    private GameObject balloon;
    private TextMeshProUGUI text;
    private new string name;

    protected abstract string Text { get; }
    protected virtual BehaviourType BehaviourType => BehaviourType.Hello;

    [SuppressMessage(Category, CheckId, Justification = Justification)]
    protected void AddBehavior<T>(T diet) where T : MonoBehaviour => gameObject.AddComponent<T>();

    protected virtual void Behaviour()
    {
        if (BehaviourType == BehaviourType.Hello
            && UIManager.inputField.text != string.Empty
            && UIManager.inputField.text != name) return;

        text.text = Text;
        balloon.SetActive(true);
    }

    protected virtual void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>(true);
        balloon = text.transform.parent.gameObject;

        if (TryGetComponent(out IHerbivore herbivore))
            name = herbivore.Name;
        else name = GetComponent<ICarnivore>().Name;
    }

    private void OnEnable() => UIManager.GetButton(BehaviourType).onClick.AddListener(Behaviour);
    private void OnDisable() => UIManager.GetButton(BehaviourType).onClick.RemoveListener(Behaviour);
}