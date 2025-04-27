using UnityEngine;

public class ItemSpeed : Item
{
    [SerializeField] private float _speeding;

    public override void Use(GameObject owner)
    {
        Mover mover = owner.GetComponent<Mover>();

        if (mover != null)
        {
            mover.Boost(_speeding);
        }
    }
}
