using System;
using DG.Tweening;
using UnityEngine;

namespace Rehawk.DOTweenSequencing
{
    [Serializable]
    [TweenStep("Misc/Invoke Named Event")]
    public class InvokeNamedEventStep : TweenStepBase
    {
        [SerializeField] private string forwardEvent = "ForwardEvent";
        [SerializeField] private string backwardsEvent = "BackwardsEvent";

        protected override Tween CreateTween(DOTweenSequencer sequencer)
        {
            return TweenStepUtils.CreateReversibleInstant(
                onForward: () => sequencer.InvokeNamedEvent(forwardEvent),
                onBackwards: () => sequencer.InvokeNamedEvent(backwardsEvent)
            );
        }
    }
}