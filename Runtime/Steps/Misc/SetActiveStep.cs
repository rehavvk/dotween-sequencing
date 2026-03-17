using System;
using DG.Tweening;
using UnityEngine;

namespace Rehawk.DOTweenSequencing
{
    [Serializable]
    [TweenStep("Misc/Set Active")]
    public class SetActiveStep : TweenStepBase<GameObject>
    {
        [SerializeField] private bool isActive = true;

        protected override Tween CreateTween(DOTweenSequencer sequencer)
        {
            if (!TryGetTarget(out GameObject obj)) 
                return null;

            return TweenStepUtils.CreateReversibleInstant(
                onForward: () => obj.SetActive(isActive),
                onBackwards: () => obj.SetActive(!isActive)
            );
        }
    }
}
