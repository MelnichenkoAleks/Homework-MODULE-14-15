using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private CharacterController _characterController;

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
        _speed += amount;

        Debug.Log($"√ерой использовал ускорение, текуща€ скорость: {_speed}");
    }
}
