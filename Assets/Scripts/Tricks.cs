using Buttons;
using System.Collections;
using UnityEngine;

internal interface ICanTrick
{
    Tricks Tricks { get; }
}

public class Tricks : Animal
{
    protected override string Text => string.Empty;
    protected override ButtonType ButtonType => ButtonType.Trick;

    protected override void Speak() => StartCoroutine(DoTrick());

    private IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }
}