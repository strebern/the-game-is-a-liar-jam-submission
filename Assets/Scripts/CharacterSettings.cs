using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "CharacterSettings", menuName = "Character/CharacterSettings")]
    public class CharacterSettings : ScriptableObject
    {
        public string Name;
        public List<ItemScript> Items;
        public LiesScript Lie;
    }
}