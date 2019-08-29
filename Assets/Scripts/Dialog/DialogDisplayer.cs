using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Dialog
{
    [DisallowMultipleComponent]
    public class DialogDisplayer : MonoBehaviour
    {
        public bool IsBeingDisplayed = false;
        public bool IsFullyDisplayed = false;

        [Header("Settings")]
        [SerializeField] private float _secondsBetweenCharacters;
        
        [Header("References")]
        [SerializeField] private GameObject _dialogBox;
        [SerializeField] private TextMeshProUGUI _text;

        [Header("Events")]
        public UnityEvent OnTextFullyDisplayed;

        private bool _dialogInterrupted = false;
        
        // PUBLIC

        public void SetText(string text)
        {
            _text.text = text;
        }

        public void SetTextCharacterByCharacter(string text)
        {
            IsFullyDisplayed = false;
            StopAllCoroutines();
            StartCoroutine(SetTextCharacterByCharacterRoutine(text));
        }

        public void InterruptDialog()
        {
            _dialogInterrupted = true;
        }

        public void ShowDialogBox()
        {
            Debug.Log("Showing dialog box");
            _dialogBox.SetActive(true);
        }

        public void HideDialogBox()
        {
            _dialogBox.SetActive(false);
        }
        
        // PRIVATE

        private IEnumerator SetTextCharacterByCharacterRoutine(string text)
        {
            var tempText = "";

            IsBeingDisplayed = true;
            
            for (int i = 0; i <= text.Length; i++)
            {
                tempText = text.Substring(0, i);
                if (!_dialogInterrupted)
                {
                    SetText(tempText);
                    yield return new WaitForSeconds(_secondsBetweenCharacters);
                }
                else
                {
                    SetText(tempText + "...");
                    yield break;
                }
            }

            IsBeingDisplayed = false;
            IsFullyDisplayed = true;
            
            OnTextFullyDisplayed?.Invoke();
        }
    }
}