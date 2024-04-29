using UnityEngine;

namespace Zoo
{
    internal class Zebra : Animal, IHerbivore
    {
        [SerializeField]
        public string name;

        protected override string Text => "zebra zebra";

        public Herbivore Herbivore { get; }
        private void Start() => AddDiet(Herbivore);
        public string EatText => "munch munch zank yee bra";
    }
}