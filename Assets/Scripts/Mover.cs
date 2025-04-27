using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private CharacterController _characterController;

    [SerializeField] private ParticleSystem _boostEffect;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void ProcessMoveTo(Vector3 direction)
    {
        _characterController.Move(direction * _speed * Time.deltaTime);
    }

    public void Boost(float amount)
    {
        if (amount < 0)
        {
            Debug.LogError("Отрицательное значение быть не может");
            return;
        }

        _speed += amount;

        _boostEffect.Play();

        Debug.Log($"Герой использовал ускорение, текущая скорость: {_speed}");
    }
}
