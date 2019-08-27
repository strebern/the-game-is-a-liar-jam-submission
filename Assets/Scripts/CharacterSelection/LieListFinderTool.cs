using UnityEngine;
using Game.Lies;
using System.Collections.Generic;
using Game.Inventory;

public class LieListFinderTool : MonoBehaviour
{
    [SerializeField] LiesList _liesList;
    [SerializeField] ItemList _itemList;

    [SerializeField] LiesScript[] _allLies;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            FindLiesByRank(0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            FindLiesByRank(1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            FindLiesByRank(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            FindLiesByRank(3);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            FindLiesByRank(4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            FindLiesByRank(5);
        }

        /*  WARNING USE ONLY TO RANDOMIZE ALL LIES TAGS
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
           // SetRandomeLiesValueByRank();
        }
        */
    }


    private void FindLiesByRank(int rank)
    {
        int Armor = 0;
        int Bow = 0;
        int Cape = 0;
        int Dagger = 0;
        int Helmet = 0;
        int Shield = 0;
        int Spear = 0;
        int Sword = 0;
        int Unarmed = 0;
        int Wand = 0;
        int Axe = 0;

        foreach (LiesScript lie in _liesList.LiesCompleteList)
        {
            if (lie.LieRank == rank)
            {
                foreach (string lieTag in lie.LieTags)
                {
                    // Debug.LogError(lieTag);

                    switch (lieTag)
                    {
                        case "Armor":
                            Armor++;
                            break;
                        case "Bow":
                            Bow++;
                            break;
                        case "Cape":
                            Cape++;
                            break;
                        case "Dagger":
                            Dagger++;
                            break;
                        case "Helmet":
                            Helmet++;
                            break;
                        case "Shield":
                            Shield++;
                            break;
                        case "Spear":
                            Spear++;
                            break;
                        case "Sword":
                            Sword++;
                            break;
                        case "Unarmed":
                            Unarmed++;
                            break;
                        case "Wand":
                            Wand++;
                            break;
                        case "Axe":
                            Axe++;
                            break;

                    }
                }
            }
        }
        Debug.LogError("Armor : " + Armor);
        Debug.LogError("Bow : " + Bow);
        Debug.LogError("Cape : " + Cape);
        Debug.LogError("Dagger : " + Dagger);
        Debug.LogError("Helmet : " + Helmet);
        Debug.LogError("Shield : " + Shield);
        Debug.LogError("Spear : " + Spear);
        Debug.LogError("Sword : " + Sword);
        Debug.LogError("Unarmed : " + Unarmed);
        Debug.LogError("Wand : " + Wand);
        Debug.LogError("Axe : " + Axe);
    }

    private void SetRandomeLiesValueByRank()
    {

        List<string> ItemListBuffer = new List<string>();


        int i = 0;
        while (i <= 50)
        {
            foreach (ItemScript item in _itemList.ItemSelection)
            {
                ItemListBuffer.Add(item.ItemName);
            }



            string item1 = ItemListBuffer[Random.Range(0, ItemListBuffer.Count)];
            _allLies[i].LieTags[0] = item1;
            ItemListBuffer.Remove(item1);

            string item2 = ItemListBuffer[Random.Range(0, ItemListBuffer.Count)];
            _allLies[i].LieTags[1] = item2;
            ItemListBuffer.Remove(item2);

            string item3 = ItemListBuffer[Random.Range(0, ItemListBuffer.Count)];
            _allLies[i].LieTags[2] = item3;

            ItemListBuffer.Clear();
            i++;
        }



        /*
        foreach (LiesScript lie in _allLies)
        {
            int i = 0;
            foreach (string lieTag in lie.LieTags)
            {
                lie.LieTags[i] = "sword";
                i++;
            }


                int i = 0;
                foreach (string lieTag in lie.LieTags)
                {
                    ItemScript item = _itemList.ItemSelection[Random.Range(0, _itemList.ItemSelection.Length)];
                    lie.LieTags[i] = item.TAG;
                    i++;
                }

            }
            */
    }
}
