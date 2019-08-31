using Game.Dialog;
using UnityEngine;

namespace Game.CharacterSelection
{
    [DisallowMultipleComponent]
    public class CharactersFadeOut : MonoBehaviour
    {
        public void FadeOut()
        {
            foreach (var dialogDisplayer in GetComponentsInChildren<DialogDisplayer>())
            {
                dialogDisplayer.HideDialogBox();
            }

            foreach (var animator in GetComponentsInChildren<Animator>())
            {
                animator.SetBool("Fade", true);
            }
        }
    }
}
