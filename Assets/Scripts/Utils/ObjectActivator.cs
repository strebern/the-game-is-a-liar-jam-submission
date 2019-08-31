using UnityEngine;

namespace Game.Utils
{
    public class ObjectActivator : MonoBehaviour
    {
        [Header("Target")]
        [SerializeField] private GameObject _target;

        public void SetActive(bool b)
        {
            _target.SetActive(b);
        }
    }
}