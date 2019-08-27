using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.CharacterSelection
{
    [CreateAssetMenu(fileName = "CharacterSelectionSettings", menuName = "CharacterSelection/MainSettings")]
    public class CharacterSelectionSettings : ScriptableObject
    {
        public int CrewSize;
        public int CharactersPerSelection;
        public float SecondsPerSelection;
        public GameObject CharacterPrefab;
    }
}

