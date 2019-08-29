using Game.Dialog;
using Game.Lies;
using UnityEngine;
using UnityEngine.Events;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterPresenter : MonoBehaviour
    {
        public bool IsActive = false;

        [Header("Events")]
        public UnityEvent OnPresentationBeginning;
        public UnityEvent OnPresentationEnding;
        
        // PUBLIC

        public void BeginPresentation()
        {
            IsActive = true;
            
            GetComponentInChildren<LieGenerator>().GenerateLie();
            
            OnPresentationBeginning?.Invoke();
        }

        public void EndPresentation()
        {
            IsActive = false;
            
            GetComponentInChildren<DialogDisplayer>().InterruptDialog();

            OnPresentationEnding?.Invoke();
        }
    }
}