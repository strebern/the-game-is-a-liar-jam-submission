using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterPresentationManager : MonoBehaviour
    {
        public List<CharacterPresenter> CharacterPresenters;

        [Header("Events")]
        public UnityEvent OnPresentationRoundBeginning;
        public UnityEvent OnAllCharactersPresent;
        public UnityEvent OnPresentationRoundEnding;

        private int _currentPresentationIndex = 0;
        
        // CORE

        private void Update()
        {
            if (Input.GetButtonDown("SkipPresentation"))
            {
                SwitchToNextPresentation();
            }
        }

        // PUBLIC

        public void StartNewPresentationRound()
        {
            StopAllCoroutines();
            StartCoroutine(StartNewPresentationRoundRoutine());
        }
        
        public void SwitchToNextPresentation()
        {
            CharacterPresenters[_currentPresentationIndex].EndPresentation();
            _currentPresentationIndex++;

            if (_currentPresentationIndex < CharacterPresenters.Count)
            {
                CharacterPresenters[_currentPresentationIndex].BeginPresentation();
            }
            else
            {
                OnPresentationRoundEnding?.Invoke();
            }
        }

        // PRIVATE

        private IEnumerator StartNewPresentationRoundRoutine()
        {
            _currentPresentationIndex = 0;

            OnPresentationRoundBeginning?.Invoke();
            yield return new WaitForSeconds(2f);
            OnAllCharactersPresent?.Invoke();
        }
    }
}