using UnityEngine;

namespace Game.Inventory
{
    [CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item", order = 1)]
    public class Item : ScriptableObject
    {
        public string Name;
        public Sprite Sprite;
    }
}
