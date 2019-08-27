using System.Collections.Generic;
using UnityEngine;

namespace Game.Character
{
    [CreateAssetMenu(fileName = "CharacterList", menuName = "Character/CharacterList", order = 0)]
    public class CharacterList : ScriptableObject
    {
        public List<Character> Characters;
    }
}