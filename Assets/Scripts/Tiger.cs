using System.Collections;
using UnityEngine;

namespace Zoo
{
    internal class Tiger : Animal, ICarnivore
    {
        public string name;

        protected override string Text => "rraaarww";
        public Carnivore Carnivore { get; set; }
        private void Start() => Carnivore = gameObject.AddComponent<Carnivore>();
        public string EatText => "nomnomnom thx wubalubadubdub";

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
