using System.Collections.Generic;
using Game.Inventory;
using UnityEngine;

namespace Game.Character
{
    [DisallowMultipleComponent]
    public class CharacterBuilder : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Inventory.Inventory _inventory;

        [Header("Items Objects")]
        [SerializeField] private List<GameObject> _itemsObjects;

        public void BuildCharacter()
        {
            foreach (var itemObject in _itemsObjects)
            {
                foreach (var item in _inventory.Items)
                {
                    if (item.Name == itemObject.name) // TODO: REPLACE WITH LABEL
                    {
                        itemObject.SetActive(true);
                    }
                }
            }
        }
    }
}