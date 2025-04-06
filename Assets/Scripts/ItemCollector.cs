using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private string _itemName;

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();
        {
            if(item != null)
            {
                Take(item.NameItem);
                Destroy(item.gameObject);
            }
        }
    }

    public void Take(string items)
    {
        if (items == null)
        {
            Debug.LogError("Items равно Null ");
            return;
        }

        _itemName = items;
        Debug.Log($"Вы подобрали предмет: {_itemName}");
    }
}
