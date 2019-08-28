using Game.Dialog;
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
            
            Debug.Log("Plop");
            
            var dialogDisplayer = GetComponentInChildren<DialogDisplayer>();
            dialogDisplayer.ShowDialogBox();
            dialogDisplayer.SetTextCharacterByCharacter("blalbalbalaldqssaall",.2f);
            
            OnPresentationBeginning?.Invoke();
        }

        public void EndPresentation()
        {
            IsActive = false;
            
            var dialogDisplayer = GetComponentInChildren<DialogDisplayer>();
            dialogDisplayer.HideDialogBox();

            OnPresentationEnding?.Invoke();
        }
    }
}