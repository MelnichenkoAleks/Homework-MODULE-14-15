using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Transform _itemHeroPoint;

    private string _itemName;

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

    public void AttachItemToHeroPoint(Item item)
    {
        if (_itemHeroPoint != null)
        {
            item.transform.SetParent(_itemHeroPoint);

            item.transform.localPosition = Vector3.zero;
            item.transform.localRotation = Quaternion.identity;

            Collider itemCollider = item.GetComponent<Collider>();

            if (itemCollider)
                itemCollider.enabled = false;

            item.HasTaken();
        }
        else
        {
            Debug.LogError("Точка спавна оружия у игрока = null");
        }
    }
}
