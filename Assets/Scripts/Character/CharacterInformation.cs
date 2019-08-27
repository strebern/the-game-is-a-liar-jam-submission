using System.Collections.Generic;
using Game.Inventory;
using Game.Lies;
using UnityEngine;

namespace Game.Character
{
    [CreateAssetMenu(fileName = "CharacterSettings", menuName = "Character/CharacterSettings")]
    public class CharacterInformation : ScriptableObject
    {
        public string Name;
        public List<Inventory.ItemScript> Items;
        public Lies.LiesScript Lie;
    }
}
