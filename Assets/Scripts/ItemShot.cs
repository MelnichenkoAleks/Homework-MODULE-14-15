using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShot : Item
{
    private string _ItemName = "Item Shot";
    public override string NameItem => _ItemName;

    protected override void ItemAbility()
    {
        throw new System.NotImplementedException();
    }
}
