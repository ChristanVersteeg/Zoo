public class Turtle : Animal, IHerbivore, ICarnivore, ICanTrick
{
    public string Name => "Wumpie";

    protected override string Text => "I am speed";

    string IHerbivore.EatText => "Yummy tasty leaves";
    string ICarnivore.EatText => "Hehe fleshy snail";
    public Herbivore Herbivore { get; }
    public Carnivore Carnivore { get; }
    public Tricks Tricks { get; }

    private void Start()
    {
        AddBehavior(Herbivore);
        AddBehavior(Carnivore);
        AddBehavior(Tricks);
    }
}