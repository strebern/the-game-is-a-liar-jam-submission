﻿using System;
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
        public UnityEvent OnAllCharactersIntroduced;
        public UnityEvent OnPresentationRoundEnding;
        public UnityEvent OnAllCharactersDisappeared;

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

        public void EndCurrentPresentationRound()
        {
            StopAllCoroutines();
            StartCoroutine(EndCurrentPresentationRoundRoutine());
        }
        
        public void SwitchToNextPresentation()
        {
            _currentPresentationIndex++;
            if (_currentPresentationIndex < CharacterPresenters.Count)
            {
                CharacterPresenters[_currentPresentationIndex-1].EndPresentation();
                CharacterPresenters[_currentPresentationIndex].BeginPresentation();
            }
            else
            {
                OnAllCharactersIntroduced?.Invoke();
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
        
        private IEnumerator EndCurrentPresentationRoundRoutine()
        {
            OnPresentationRoundEnding?.Invoke();
            yield return new WaitForSeconds(3f);
            OnAllCharactersDisappeared?.Invoke();
        }
    }
}