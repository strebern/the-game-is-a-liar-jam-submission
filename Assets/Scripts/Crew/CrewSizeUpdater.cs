using TMPro;
using UnityEngine;

namespace Game.Crew
{
    [DisallowMultipleComponent]
    public class CrewSizeUpdater : MonoBehaviour
    {
        [Header("UI References")] 
        [SerializeField] private TextMeshProUGUI _crewSizeText;
        
        [Header("Settings")] 
        [SerializeField] private Crew _settings; 
        
        public void UpdateCrewSizeText(int crewSize)
        {
            _crewSizeText.text = "Crew size : " + crewSize + "/" + _settings.MaxCrewSize;
        }
    }
}