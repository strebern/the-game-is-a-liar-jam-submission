using UnityEngine;

namespace Game.Utils
{
    [DisallowMultipleComponent]
    public class AnimatorTrigger : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private string _triggerName;

        [Header("References")]
        [SerializeField] private Animator _animator;

        public void Trigger()
        {
            _animator.SetTrigger(_triggerName);   
        }
    }
}