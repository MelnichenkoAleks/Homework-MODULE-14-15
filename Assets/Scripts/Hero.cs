using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private float _currentHealth = 100;
    
    public float CurrentHealth => _currentHealth;

    private string _horizontalAxisName = "Horizontal";
    private string _verticalAxisName = "Vertical";

    private CharacterController _characterController;

    private float _deadZone = 0.1f;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        if (input.magnitude <= _deadZone)
            return;

        Vector3 normalizedInput = input.normalized;

        ProcessMoveTo(normalizedInput);

        ProcessRotateTo(normalizedInput);
    }

    private void ProcessMoveTo(Vector3 direction)
    {
        _characterController.Move(direction * _speed * Time.deltaTime);
    }

    private void ProcessRotateTo(Vector3 direction)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        float step = _rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}
