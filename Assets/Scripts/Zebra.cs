using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Zebra : Animal
    {
        [SerializeField]
        public string name;

        protected override string HelloText => "zebra zebra";

        //public void EatLeaves() => text.text = "munch munch zank yee bra";
    }
}
