using Game.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Game.CharacterSelection
{
    public class CharacterHighlighter : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Button _targetButton; 
        
        public void Highlight(bool b)
        {
            if (_targetButton.interactable)
            {
                GetComponentInChildren<ObjectActivator>().SetActive(b);
            }
        }
    }
}