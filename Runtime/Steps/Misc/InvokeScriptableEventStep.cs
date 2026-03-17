using System;
using DG.Tweening;
using UnityEngine;

namespace Rehawk.DOTweenSequencing
{
    [Serializable]
    [TweenStep("Misc/Invoke Scriptable Event")]
    public class InvokeScriptableEventStep : TweenStepBase
    {
        [SerializeField] private ScriptableEvent forwardEvent;
        [SerializeField] private ScriptableEvent backwardsEvent;

        protected override Tween CreateTween(DOTweenSequencer sequencer)
        {
            return TweenStepUtils.CreateReversibleInstant(
                onForward: () => sequencer.InvokeScriptableEvent(forwardEvent),
                onBackwards: () => sequencer.InvokeScriptableEvent(backwardsEvent)
            );
        }
    }
}