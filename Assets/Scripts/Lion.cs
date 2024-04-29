using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Lion : Animal
    {
        public string name;

        protected override string HelloText => "roooaoaaaaar";

        //public void SayHello() => text.text = "roooaoaaaaar";
        //public void EatMeat() => text.text = "nomnomnom thx mate";
    }
}
