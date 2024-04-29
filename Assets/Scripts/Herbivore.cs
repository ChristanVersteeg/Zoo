using Buttons;

internal interface IHerbivore
{
    Herbivore Herbivore { get; }
}

public class Herbivore : Animal
{
    public override string Text { get; set; }
    protected override ButtonType ButtonType => ButtonType.Leaves;
}