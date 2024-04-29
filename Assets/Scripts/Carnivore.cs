using Buttons;

internal interface ICarnivore
{
    string Name { get; }
    string EatText { get; }
    Carnivore Carnivore { get; }
}

public class Carnivore : Animal
{
    private ICarnivore icarnivore;

    protected override void Awake()
    {
        base.Awake();

        icarnivore = GetComponent<ICarnivore>();
    }

    protected override string Text => icarnivore.EatText;
    protected override BehaviourType BehaviourType => BehaviourType.Meat;
}