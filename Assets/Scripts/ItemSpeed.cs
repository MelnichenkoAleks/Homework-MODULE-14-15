using UnityEngine;

public class ItemSpeed : Item
{
    [SerializeField] private Mover _mover;

    [SerializeField] private float _speeding;

    private string _ItemName = "Item Speed";
    public override string NameItem => _ItemName;

    public override void ItemAbility()
    {
        if (_mover != null)
        {
            _mover.Boost(_speeding);
        }
    }
}
