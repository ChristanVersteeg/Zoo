namespace Zoo
{
    internal class Pig : Animal, IHerbivore, ICarnivore, ICanTrick
    {
        public string Name => "Dora";

        protected override string Text => "oink oink";

        public Herbivore Herbivore { get; }
        public Carnivore Carnivore { get; }
        public Tricks Tricks { get; }
        private void Start()
        {
            AddBehavior(Herbivore);
            AddBehavior(Carnivore);
            AddBehavior(Tricks);
        }
        string IHerbivore.EatText => "munch munch oink";
        string ICarnivore.EatText => "nomnomnom oink thx";
    }
}