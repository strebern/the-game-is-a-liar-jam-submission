using System.Collections.Generic;
using Game.Inventory;
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

        public void AddCharacterToCrew(List<Item> characterItems, string characterName)
        {
            _crew.Members[CurrentCrewSize].Items = characterItems;
            _crew.Members[CurrentCrewSize].name = characterName;

            CurrentCrewSize++;

            OnCrewSizeIncreased?.Invoke(CurrentCrewSize);

            if (_crew.Members.Count >= _crew.MaxCrewSize)
            {
                OnCrewFull?.Invoke();
            }
        }
    }
}