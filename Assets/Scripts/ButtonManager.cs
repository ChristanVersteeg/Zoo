using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
    public enum ButtonType
    {
        Leaves,
        Meat,
        Trick,
        Hello
    }

    public class ButtonManager : MonoBehaviour
    {
        public static Button[] buttons;

        private void Awake() => buttons = GetComponentsInChildren<Button>();

        public static Button GetButton(ButtonType buttonType) => buttons[(int)buttonType];
    }
}