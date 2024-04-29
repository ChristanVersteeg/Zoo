using System.Collections;
using UnityEngine;

namespace Zoo
{
    internal class Pig : Animal, IHerbivore, ICarnivore
    {
        public string name;

        protected override string Text => "oink oink";
        public Herbivore Herbivore { get; }
        public Carnivore Carnivore { get; }
        private void Start()
        {
            AddDiet(Herbivore);
            AddDiet(Carnivore);
        }

        string IHerbivore.EatText => "munch munch oink";
        string ICarnivore.EatText => "nomnomnom oink thx";

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
