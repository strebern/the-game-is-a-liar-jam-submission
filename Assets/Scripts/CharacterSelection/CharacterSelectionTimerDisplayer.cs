using UnityEngine;
using TMPro;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterSelectionTimerDisplayer : MonoBehaviour
    {
        [Header("UI References")] 
        [SerializeField] private TextMeshProUGUI _timerText;
        
        public void UpdateTimer(int timeLeft)
        {
            _timerText.text = timeLeft + "seconds left";
        }
    }
}
