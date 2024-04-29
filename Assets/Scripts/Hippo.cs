namespace Zoo
{
    internal class Hippo : Animal, IHerbivore
    {
        public string Name => "Elsa";

        protected override string Text => "splash";

        public Herbivore Herbivore { get; set; }
        private void Start() => AddDiet(Herbivore);
        public string EatText => "munch munch lovely";
    }
}