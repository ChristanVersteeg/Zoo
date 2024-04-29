using Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Zebra : Animal, IHerbivore
    {
        [SerializeField]
        public string name;

        public Herbivore Herbivore { get; set; }
        public override string Text { get; set; }

        protected override void Awake()
        {
            base.Awake();

            Herbivore = gameObject.AddComponent<Herbivore>();
            Text = "zebra zebra";
            Herbivore.Text = "munch munch zank yee bra";
        }
    }
}