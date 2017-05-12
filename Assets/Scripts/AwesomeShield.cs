﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AwesomeShield", menuName = "Items/Shields/Awesome Shield")]
public class AwesomeShield : ShieldConfig
{
    public Vector3 MaxScale;
    public Vector3 InitialScale;

    public bool isBlocking;

    public override void Block()
    {
        if (isBlocking)
            return;

        this._owner.transform.localScale = MaxScale;
        isBlocking = true;
    }

    public override void StopBlock()
    {
        if (!isBlocking)
            return;

        this._owner.transform.localScale = InitialScale;
        isBlocking = false;
    }

    public override void Initialize(GameObject obj)
    {
        base.Initialize(obj);
        InitialScale = _owner.transform.localScale;
        MaxScale = _owner.transform.localScale * ShieldGrowth;
    }
}
