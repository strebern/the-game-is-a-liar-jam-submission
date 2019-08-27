using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterSelectionTimer : MonoBehaviour
    {
        [Header("Events")] 
        public IntEvent OnTimerUpdated;
        public UnityEvent OnTimerOver;

        public void StartTimer()
        {
            StartCoroutine(TimerUpdateRoutine());
        }

        private IEnumerator TimerUpdateRoutine()
        {
            var timer = 15;

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