using System;
using DG.Tweening;
using UnityEngine;

namespace Rehawk.DOTweenSequencing
{
    [Serializable]
    [TweenStep("Misc/Enable Behaviour")]
    public class EnableBehaviourStep : TweenStepBase<Behaviour>
    {
        [SerializeField] private bool isEnabled = true;

        protected override Tween CreateTween(DOTweenSequencer sequencer)
        {
            if (!TryGetTarget(out Behaviour behaviour)) 
                return null;
            
            return TweenStepUtils.CreateReversibleInstant(
                onForward: () => behaviour.enabled = isEnabled,
                onBackwards: () => behaviour.enabled = !isEnabled
            );
        }
    }
}
