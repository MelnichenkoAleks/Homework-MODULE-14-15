using UnityEngine;

public class ItemHealth : Item
{
    [SerializeField] private float _healing;

    private string _ItemName = "Item Health";
    public override string NameItem => _ItemName;

    public override void ItemAbility(GameObject owner)
    {
        Health _health = owner.GetComponent<Health>();

        if (_health != null)
        {
            _health.Heal(_healing);
        }
    }
}
