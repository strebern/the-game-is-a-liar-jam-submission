using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Utils
{
    public class ButtonsActivator : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private List<Button> _buttons;

        public void ActivateButtons()
        {
            foreach (var button in _buttons)
            {
                button.interactable = true;
            }
        }

        public void DeactivateButtons()
        {
            foreach (var button in _buttons)
            {
                button.interactable = false;
            }
        }
    }
}