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
        
        [Header("References")]
        [SerializeField] private GameObject _dialogBox;
        [SerializeField] private TextMeshProUGUI _text;

        [Header("Events")]
        public UnityEvent OnTextFullyDisplayed;
        
        // PUBLIC

        public void SetText(string text)
        {
            _text.text = text;
        }

        public void SetTextCharacterByCharacter(string text, float secondsBetweenCharacters)
        {
            IsFullyDisplayed = false;
            StopAllCoroutines();
            StartCoroutine(SetTextCharacterByCharacterRoutine(text, secondsBetweenCharacters));
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

        private IEnumerator SetTextCharacterByCharacterRoutine(string text, float secondsBetweenCharacters)
        {
            var tempText = "";

            IsBeingDisplayed = true;
            
            for (int i = 0; i <= text.Length; i++)
            {
                tempText = text.Substring(0, i);
                SetText(tempText);
                yield return new WaitForSeconds(secondsBetweenCharacters);
            }

            IsBeingDisplayed = false;
            IsFullyDisplayed = true;
            
            OnTextFullyDisplayed?.Invoke();
        }
    }
}