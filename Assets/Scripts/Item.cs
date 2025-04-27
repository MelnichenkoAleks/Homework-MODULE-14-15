using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private float _destroyTime;

    [SerializeField] private float _rotateSpeed;

    [SerializeField] private string _itemName;
    public string ItemName => _itemName;

    private Vector3 _defaultPosition;

    private float _time;

    private bool _isTake;

    private void Awake()
    {
        _defaultPosition = transform.position;
    }

    private void Update()
    {
        if (_isTake == false)
        {
            _time += Time.deltaTime * 5;

            transform.Rotate(Vector3.up, _rotateSpeed);

            transform.position = _defaultPosition + Vector3.up * Mathf.Sin(_time) / 5;

            if (_time >= _destroyTime)
                Destroy(gameObject);
        }
    }

    public abstract void Use(GameObject owner);

    public bool CanUse(GameObject owner)
    {
        return owner.GetComponent<MoveController>() != null;
    }

    public void Take()
    {
        _isTake = true;
    }
}
