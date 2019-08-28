using System;
using UnityEngine;

namespace Game.Dialog
{
    public class DialogSkipper : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private DialogDisplayer _dialogDisplayer;
        
        private void Update()
        {
            if (Input.GetButtonDown("SkipDialog") && _dialogDisplayer.IsBeingDisplayed)
            {
                
            }
        }
    }
}