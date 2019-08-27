﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Inventory
{
    public class CharacterInventory : MonoBehaviour
    {
        public StringEvent OnItemsSet;

        [SerializeField] ItemList _itemList;

        private List<ItemScript> _characterItemList = new List<ItemScript>();
        //CORE

        private void Awake()
        {
            SetCharacterItems();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                SetCharacterItems();
            }
        }

        //PUBLIC

        public List<ItemScript> GetCharacterItems()
        {
            return _characterItemList;
        }

        //PRIVATE

        private void SetCharacterItems()
        {
            _characterItemList.Clear();
            int step = 3;
            List<ItemScript> ItemListBuffer = new List<ItemScript>();

            foreach (ItemScript item in _itemList.ItemSelection)
            {
                ItemListBuffer.Add(item);
            }

            while (step > 0)
            {
                ItemScript item = ItemListBuffer[Random.Range(0, ItemListBuffer.Count)];
                _characterItemList.Add(item);
                ItemListBuffer.Remove(item);
                Debug.LogError("Selected : " + item);

                step--;
            }

            OnItemsSet.Invoke(GetRandomItemTag());
        }

        private string GetRandomItemTag()
        {
            ItemScript item = _characterItemList[Random.Range(0, _characterItemList.Count)];
            return item.ItemName;
        }
    }
}
