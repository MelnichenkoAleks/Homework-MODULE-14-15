using UnityEngine;

public class ItemShoot : Item
{
    [SerializeField] private Bullet _bulletPrefab;

    [SerializeField] private Transform _bulletPrefabPoint;

    [SerializeField] private float _shootForce;

    public override void Use(GameObject owner)
    {
        {
            Bullet bullet = Instantiate(_bulletPrefab, _bulletPrefabPoint.position, _bulletPrefabPoint.rotation);
            bullet.Fire(transform.forward * _shootForce);
        }
    }
}
