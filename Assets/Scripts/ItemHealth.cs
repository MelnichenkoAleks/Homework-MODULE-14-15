using UnityEngine;

public class ItemHealth : Item
{
    [SerializeField] private Health _health;

    [SerializeField] private float _healing;

    private string _ItemName = "Item Health";
    public override string NameItem => _ItemName;

    public override void ItemAbility()
    {
        if (_health != null)
        {
            _health.Heal(_healing);
        }
    }
}
