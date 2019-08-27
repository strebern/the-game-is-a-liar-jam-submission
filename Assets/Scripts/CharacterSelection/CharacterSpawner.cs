using System.Collections.Generic;
using UnityEngine;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterSpawner : MonoBehaviour
    {
        [Header("Settings")] 
        [SerializeField] private CharacterSelectionSettings _settings;

        [Header("Spawn Points")] 
        [SerializeField] private List<Transform> _spawns;

        public void SpawnNewCharacters()
        {
            for (int i = 0; i < _settings.CharactersPerSelection; i++)
            {
                Instantiate(_settings.CharacterPrefab, _spawns[i].position, Quaternion.identity);
            }
        }

        public void DeleteCharacters()
        {
            
        }
    }
}