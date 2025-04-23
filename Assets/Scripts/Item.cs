using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private float _destroyTime;

    [SerializeField] private float _rotateSpeed;

    private Vector3 _defaultPosition;

    private float _time;

    public abstract string NameItem { get; }

    private void Awake()
    {
        _defaultPosition = transform.position;

        Destroy(gameObject, _destroyTime);
    }

    private void Update()
    {
            _time += Time.deltaTime * 5;

            transform.Rotate(Vector3.up, _rotateSpeed);

            transform.position = _defaultPosition + Vector3.up * Mathf.Sin(_time) / 5;
    }

    public abstract void ItemAbility();
}
