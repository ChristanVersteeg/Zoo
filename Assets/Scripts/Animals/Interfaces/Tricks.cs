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
    protected override BehaviourType BehaviourType => BehaviourType.Trick;

    private WaitForEndOfFrame waitForEndOfFrame = new();

    protected override void Behaviour() => StartCoroutine(DoTrick());

    private IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return waitForEndOfFrame;
        }
    }
}