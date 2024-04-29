using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Hippo : Animal
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        protected override string HelloText => "splash";

        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }
    }

}
