using System;
using DG.Tweening;
using UnityEngine;

namespace Rehawk.DOTweenSequencing
{
    [Serializable]
    [TweenStep("Transform/Blendable/Scale By")]
    public class BlendableScaleByStep : TweenStepWithTweenOptions<Transform>
    {
        [SerializeField] private Vector3 by = Vector3.one * 0.2f;
        [SerializeField] private float duration = 0.5f;

        protected override Tween CreateTween(DOTweenSequencer sequencer)
        {
            if (!TryGetTarget(out Transform transform))
                return null;
            
            return transform.DOBlendableScaleBy(by, duration);
        }
    }
}
