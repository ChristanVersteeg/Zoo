using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Lion : Animal, ICarnivore
    {
        public string name;

        protected override string Text => "roooaoaaaaar";
        public Carnivore Carnivore { get; set; }
        private void Start() => Carnivore = gameObject.GetComponent<Carnivore>();
        public string EatText => "nomnomnom thx mate";
    }
}
