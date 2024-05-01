namespace Zoo
{
    internal class Hippo : Animal, IHerbivore
    {
        public string Name => "Elsa";

        protected override string Text => "splash";

        public Herbivore Herbivore { get; }
        private void Start() => AddBehavior(Herbivore);
        public string EatText => "munch munch lovely";
    }
}