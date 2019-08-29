using System.Collections.Generic;
using Game.Inventory;
using Game.Lies;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Crew
{
    public class CrewManager : MonoBehaviour
    {
        public int CurrentCrewSize;
        
        [Header("Events")]
        public IntEvent OnCrewSizeIncreased;
        public UnityEvent OnCrewFull;
        
        [Header("Settings")]
        [SerializeField] private Crew _crew;

        public void AddCharacterToCrew(List<Item> characterItems, string characterName, Lie lie)
        {
            _crew.Members[CurrentCrewSize].Items = characterItems;
            _crew.Members[CurrentCrewSize].Name = characterName;
            _crew.Members[CurrentCrewSize].Lie = lie;

            CurrentCrewSize++;

            OnCrewSizeIncreased?.Invoke(CurrentCrewSize);

            if (CurrentCrewSize >= _crew.MaxCrewSize)
            {
                OnCrewFull?.Invoke();
            }
        }
    }
}