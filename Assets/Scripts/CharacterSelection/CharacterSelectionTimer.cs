using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterSelectionTimer : MonoBehaviour
    {
        [Header("Settings")] 
        [SerializeField] private CharacterSelectionSettings _settings;
        
        [Header("Events")] 
        public IntEvent OnTimerUpdated;
        public UnityEvent OnTimerOver;

        public void StartTimer()
        {
            StartCoroutine(TimerUpdateRoutine());
        }

        private IEnumerator TimerUpdateRoutine()
        {
            var timer = _settings.SecondsPerSelection;

            while (timer > 0)
            {
                OnTimerUpdated.Invoke(timer);
                yield return new WaitForSeconds(1f);
                timer--;
            }
            
            OnTimerOver.Invoke();
        }
    }
}