using UnityEngine;

public class ItemShot : Item
{
    [SerializeField] private Attack _attack;
    [SerializeField] private float _firePower;

    private string _ItemName = "Item Shot";
    public override string NameItem => _ItemName;

    public override void ItemAbility()
    {
        if (_attack != null)
        {
            _attack.Fire(_firePower);
            Destroy(gameObject);
        }
    }
}
