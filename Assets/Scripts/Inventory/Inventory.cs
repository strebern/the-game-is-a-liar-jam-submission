using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Inventory
{
    [DisallowMultipleComponent]
    public class Inventory : MonoBehaviour
    {
        public List<Item> Items = new List<Item>();
        
        [Header("Events")]
        public StringEvent OnItemsSet;

        [Header("References")]
        [SerializeField] private ItemList _completeItemList;

        //CORE

        private void Awake()
        {
            SetCharacterItems();
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.KeypadPeriod))
            {
                SetCharacterItems();
            }
        }

        //PRIVATE

        private void SetCharacterItems()
        {
            Items.Clear();
            int step = 3;
            List<Item> ItemListBuffer = new List<Item>();

            foreach (Item item in _completeItemList.Items)
            {
                ItemListBuffer.Add(item);
            }

            while (step > 0)
            {
                Item item = ItemListBuffer[Random.Range(0, ItemListBuffer.Count)];
                Items.Add(item);
                ItemListBuffer.Remove(item);
                Debug.Log("Selected : " + item);

                step--;
            }

            OnItemsSet.Invoke(GetRandomItemTag());
        }

        private string GetRandomItemTag()
        {
            Item item = Items[Random.Range(0, Items.Count)];
            return item.Name;
        }
    }
}
