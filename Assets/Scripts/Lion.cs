using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Lion : Animal, ICarnivore
    {
        public string name;

        protected override string Text => "roooaoaaaaar";
        public Carnivore Carnivore { get; set; }
        private void Start() => AddDiet(Carnivore);
        public string EatText => "nomnomnom thx mate";
    }
}
