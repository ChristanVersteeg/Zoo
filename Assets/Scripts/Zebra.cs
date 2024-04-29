using UnityEngine;

namespace Zoo
{
    internal class Zebra : Animal, IHerbivore
    {
        [SerializeField]
        public string name;

        protected override string Text => "zebra zebra";

        public Herbivore Herbivore { get; set; }
        private void Start() => Herbivore = gameObject.AddComponent<Herbivore>();
        public string EatText => "munch munch zank yee bra";
    }
}