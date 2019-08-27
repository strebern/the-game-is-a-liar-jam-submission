using UnityEngine;

[CreateAssetMenu(fileName = "ItemList", menuName = "Inventory/ItemList", order = 1)]
public class ItemList : ScriptableObject
{
    public ItemScript[] ItemSelection;
}
