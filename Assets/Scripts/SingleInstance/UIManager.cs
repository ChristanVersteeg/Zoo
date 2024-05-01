using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
    public enum BehaviourType
    {
        Leaves,
        Meat,
        Trick,
        Hello
    }

    public class UIManager : MonoBehaviour
    {
        public static Button[] buttons;
        public static TMP_InputField inputField;

        private void Awake()
        {
            buttons = GetComponentsInChildren<Button>();
            inputField = GetComponentInChildren<TMP_InputField>();
        }

        public static Button GetButton(BehaviourType buttonType) => buttons[(int)buttonType];
    }
}