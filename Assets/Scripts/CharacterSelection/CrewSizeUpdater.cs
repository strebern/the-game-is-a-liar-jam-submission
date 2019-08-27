using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CrewSizeUpdater : MonoBehaviour
    {
        public int CurrentCrewSize = 0;
        
        [Header("UI References")] 
        [SerializeField] private TextMeshProUGUI _crewSizeText;
        
        [Header("Settings")] 
        [SerializeField] private CharacterSelectionSettings _settings;

        [Header("Events")] 
        public UnityEvent OnCrewFull;

        public void UpdateCrewSizeText(int crewSize)
        {
            _crewSizeText.text = "" + crewSize;
        }

        public void UpdateCrewSize(int crewSize)
        {
            CurrentCrewSize++;

            if (CurrentCrewSize >= _settings.CrewSize)
            {
                OnCrewFull.Invoke();
            }
        }
    }
}