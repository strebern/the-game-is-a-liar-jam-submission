using System.Collections.Generic;
using Game.Inventory;
using Game.Lies;
using UnityEngine;

namespace Game.Character
{
    [CreateAssetMenu(fileName = "CharacterSettings", menuName = "Character/CharacterSettings")]
    public class Character : ScriptableObject
    {
        public string Name;
        public List<Item> Items;
        public Lie Lie;
    }
}
