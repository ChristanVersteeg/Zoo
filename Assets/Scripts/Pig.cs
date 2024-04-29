using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Pig : Animal
    {
        public string name;

        protected override string HelloText => "oink oink";

        // public void SayHello() => text.text = "oink oink";
        // public void EatLeaves() => text.text = "munch munch oink";
        // public void EatMeat() => text.text = "nomnomnom oink thx";

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
