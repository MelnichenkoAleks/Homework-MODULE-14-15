using UnityEngine;

public class ItemSpeed : Item
{
    [SerializeField] private float _speeding;

    private string _ItemName = "Item Speed";
    public override string NameItem => _ItemName;

    public override void ItemAbility(GameObject owner)
    {
        Mover mover = owner.GetComponent<Mover>();

        if (mover != null)
        {
            mover.Boost(_speeding);
        }
    }
}
