using UnityEngine;

public class ItemHealth : Item
{
    private Hero _hero;

    [SerializeField] private float _healing;

    private string _ItemName = "Item Health";
    public override string NameItem => _ItemName;

    protected override void ItemAbility()
    {
        
    }
}
