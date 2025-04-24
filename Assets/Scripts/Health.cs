using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    
    [SerializeField] private ParticleSystem _healEffect;

    public float CurrentHealth => _currentHealth;

    public void Heal(float amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, 100);

        _healEffect.Play();

        Debug.Log($"����� ����������� ���������, ������� ��������: {_currentHealth}");
    }
}
