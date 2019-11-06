﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class SpeedPotion : Cowwectable
{
    PlatformerCharacter2D _character;
    private void Awake()
    {
        _character = FindObjectOfType<PlatformerCharacter2D>();
    }

    public override void HandleCollected()
    {
        base.HandleCollected();
        _character.DoubleSpeed();
    }
}
