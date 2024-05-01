namespace Zoo
{
    internal class Tiger : Animal, ICarnivore, ICanTrick
    {
        public string Name => "Wally";

        protected override string Text => "rraaarww";

        public Carnivore Carnivore { get; }
        public Tricks Tricks { get; }
        private void Start()
        {
            AddBehavior(Carnivore);
            AddBehavior(Tricks);
        }

        public string EatText => "nomnomnom thx wubalubadubdub";
    }
}
