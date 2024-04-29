using Buttons;

internal interface IHerbivore
{
    string Name { get; }
    string EatText { get; }
    Herbivore Herbivore { get; }
}

public class Herbivore : Animal
{
    private IHerbivore iherbivore;

    protected override void Awake()
    {
        base.Awake();

        iherbivore = GetComponent<IHerbivore>();
    }

    protected override string Text => iherbivore.EatText;
    protected override ButtonType ButtonType => ButtonType.Leaves;
}