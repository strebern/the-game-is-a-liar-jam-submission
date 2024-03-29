﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Game
{
    [DisallowMultipleComponent]
    public class EndGameManager : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private float _battleSeconds;
        
        [Header("Events")]
        public UnityEvent OnBattleBegin;
        public UnityEvent OnBattleMiddle;
        public UnityEvent OnBattleEnd;
        
        // PUBLIC
        
        public void ActivateEndBattle()
        {
            StartCoroutine(EndBattleRoutine());
        }
        
        // PRIVATE

        private IEnumerator EndBattleRoutine()
        {
            OnBattleBegin?.Invoke();
            yield return new WaitForSeconds(_battleSeconds/2f);
            OnBattleMiddle?.Invoke();
            yield return new WaitForSeconds(_battleSeconds/2f);
            OnBattleEnd?.Invoke();
        }
    }
}