using UnityEngine;
using UnityEngine.Events;

namespace Game.Controls
{
    [DisallowMultipleComponent]
    public class AnyInputChecker : MonoBehaviour
    {
        public UnityEvent OnAnyInputPressed;
        
        private void Update()
        {
            if (Input.anyKeyDown)
            {
                OnAnyInputPressed.Invoke();
            }
        }
    }
}
