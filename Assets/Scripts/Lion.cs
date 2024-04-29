using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Lion : Animal
    {
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;
        public string name;

        protected override string HelloText => "roooaoaaaaar";

        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}
