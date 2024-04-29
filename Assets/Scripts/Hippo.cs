namespace Zoo
{
    internal class Hippo : Animal, IHerbivore
    {
        public string name;

        protected override string Text => "splash";
        public Herbivore Herbivore { get; set; }
        private void Start() => Herbivore = gameObject.AddComponent<Herbivore>();
        public string EatText => "munch munch lovely";
    }
}