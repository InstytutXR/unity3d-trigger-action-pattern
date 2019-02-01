﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class RotateToAction : ActionBase
{
    public Vector3 Rotation;
    public bool IsLocal = true;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        if (IsLocal) {
            Tween.LocalRotation(transform, Rotation, Duration, Delay, AnimationCurve, LoopType);
        } else {
            Tween.Rotation(transform, Rotation, Duration, Delay, AnimationCurve, LoopType);
        }
    }
}
