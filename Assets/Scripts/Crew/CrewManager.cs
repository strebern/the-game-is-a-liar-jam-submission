using Game.Character;
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

        public void AddCharacterToCrew(Character.Character character)
        {
            //_crew.Members[CurrentCrewSize].Items

            OnCrewSizeIncreased?.Invoke(CurrentCrewSize);

            if (_crew.Members.Count >= _crew.MaxCrewSize)
            {
                OnCrewFull?.Invoke();
            }
        }
    }
}