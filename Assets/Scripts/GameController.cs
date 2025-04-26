using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private List<Item> _item;

    [SerializeField] private GameObject _owner;

    private Item _currentItem;

    private ItemCollector _itemCollector;

    private bool _hasItem = false;

    private void Awake()
    {
        _itemCollector = GetComponent<ItemCollector>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_hasItem == false)
        {
            Item item = other.GetComponent<Item>();
            {
                if (item != null)
                {
                    _itemCollector.Take(item.NameItem);
                    _itemCollector.AttachItemToHeroPoint(item);

                    _currentItem = item;

                    _hasItem = true;
                }
            }
        }
        else
        {
            Debug.Log("Вы уже взяли предмет, используйте его чтобы взять новый предмет");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {           
            if (_currentItem)
            {
                _currentItem.ItemAbility(_owner);

                Destroy(_currentItem.gameObject);

                _currentItem = null;
                _hasItem = false;
            }
        }
    }
}
