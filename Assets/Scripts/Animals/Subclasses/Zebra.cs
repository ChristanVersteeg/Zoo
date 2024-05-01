namespace Zoo
{
    internal class Zebra : Animal, IHerbivore
    {
        public string Name => "Marty";

        protected override string Text => "zebra zebra";

        public Herbivore Herbivore { get; }
        private void Start() => AddBehavior(Herbivore);
        public string EatText => "munch munch zank yee bra";
    }
}