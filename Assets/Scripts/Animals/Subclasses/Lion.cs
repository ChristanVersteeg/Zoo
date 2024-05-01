using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Lion : Animal, ICarnivore
    {
        public string Name => "Henk";

        protected override string Text => "roooaoaaaaar";

        public Carnivore Carnivore { get; }
        private void Start() => AddBehavior(Carnivore);
        public string EatText => "nomnomnom thx mate";
    }
}
