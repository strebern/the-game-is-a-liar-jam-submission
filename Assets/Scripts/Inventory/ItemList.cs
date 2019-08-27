using UnityEngine;

namespace Game.Inventory
{
    [CreateAssetMenu(fileName = "ItemList", menuName = "Inventory/ItemList", order = 1)]
    public class ItemList : ScriptableObject
    {
        public Item[] Items;
    }
}
