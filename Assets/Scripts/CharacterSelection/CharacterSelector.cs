using System.Collections.Generic;
using Game.Character;
using UnityEngine;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharacterSelector : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private CharacterPresentationManager _presentationManager;
        [SerializeField] private List<CharacterSaver> _characterSavers;

        public void SelectRandomCharacter()
        {
            _characterSavers[Random.Range(0, _characterSavers.Count)].SaveCharacter();
            _presentationManager.StartNewPresentationRound();
        }
    }
}