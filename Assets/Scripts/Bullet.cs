using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigibody;

    [SerializeField] private ParticleSystem _bulletEffect;

    public void Fire(Vector3 force)
    {
        transform.rotation = Quaternion.LookRotation(force);

        _rigibody.AddForce(force);

        _bulletEffect.Play();
    }
}
