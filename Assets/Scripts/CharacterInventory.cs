using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    [SerializeField] ItemList _itemList;

    private List<ItemScript> CharacterItemList = new List<ItemScript>();
    //CORE

    private void Awake()
    {
        GetCharacterItems();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            GetCharacterItems();
        }
    }

    //PRIVATE

    private void GetCharacterItems()
    {
        CharacterItemList.Clear();
        int step = 3;
        List<ItemScript> ItemListBuffer = new List<ItemScript>();

        foreach (ItemScript item in _itemList.ItemSelection)
        {
            ItemListBuffer.Add(item);
        }

        while (step > 0)
        {
            ItemScript item = ItemListBuffer[Random.Range(0, ItemListBuffer.Count)];
            CharacterItemList.Add(item);
            ItemListBuffer.Remove(item);
            Debug.LogError("Selected : " + item);

            step--;
        }
    }

    private void SetItemsGraphics()
    {
        foreach(ItemScript item in CharacterItemList)
        {
            // set item graphics data
        }
    }
}
