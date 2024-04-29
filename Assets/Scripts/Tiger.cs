using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Tiger : MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;


        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "rraaarww";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx wubalubadubdub";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        private IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
