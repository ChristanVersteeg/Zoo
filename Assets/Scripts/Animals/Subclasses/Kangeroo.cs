namespace Zoo
{
    public class Kangeroo : Animal, IHerbivore
    {
        public string Name => "Kang the Conqueror";

        protected override string Text => "I will punch you if you get any closer";

        string IHerbivore.EatText => "Screw this food *hops away*";
        public Herbivore Herbivore { get; }
        private void Start() => AddBehavior(Herbivore);
    }
}