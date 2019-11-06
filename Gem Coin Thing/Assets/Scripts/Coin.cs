using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Cowwectable
{

    public override void HandleCollected()
    {
        base.HandleCollected();
        CollectibleManager.Instance.HandleCoinCollected();
    }



}
