using UnityEngine;

public class ItemHealth : Item
{
    [SerializeField] private float _healing;

    public override void Use(GameObject owner)
    {
        Health _health = owner.GetComponent<Health>();

        if (_health != null)
        {
            _health.Heal(_healing);
        }
    }
}
