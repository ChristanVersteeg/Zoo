using UnityEngine;

namespace Zoo
{
    public class DeactivateAfterSeconds : MonoBehaviour
    {
        private void Deactivate() => gameObject.SetActive(false);

        private void OnEnable() => Invoke(nameof(Deactivate), 5);
    }
}