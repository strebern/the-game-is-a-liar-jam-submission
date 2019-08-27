﻿using System.Collections.Generic;
using System.Security.Cryptography;
using Game.CharacterSelection;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Character
{
    [DisallowMultipleComponent]
    public class CharacterSpawner : MonoBehaviour
    {
        [Header("Settings")] 
        [SerializeField] private CharacterSelectionSettings _settings;

        [Header("Spawn Points")] 
        [SerializeField] private List<Transform> _spawns;

        [Header("Events")] 
        public UnityEvent OnAllCharactersSpawned;

        public void SpawnNewCharacters()
        {
            DeleteCharacters();
            
            for (int i = 0; i < _settings.CharactersPerSelection; i++)
            {
                var characterInstance = Instantiate(_settings.CharacterPrefab, _spawns[i]);
            }
            
            OnAllCharactersSpawned.Invoke();
        }

        public void DeleteCharacters()
        {
            foreach (var spawn in _spawns)
            {
                if (spawn.childCount > 0)
                {
                    Destroy(spawn.GetChild(0));
                }
            }
        }
    }
}