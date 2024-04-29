using Buttons;
using TMPro;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private GameObject balloon;
    private TextMeshProUGUI text;

    public abstract string Text { get; set; }
    protected virtual ButtonType ButtonType => ButtonType.Hello;

    private void Speak()
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