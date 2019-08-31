using UnityEngine;

namespace Game.Utils
{
    [DisallowMultipleComponent]
    public class DontDestroyOnLoad : MonoBehaviour
    {
        public static GameObject Instance;
    
        private void Awake()
        {
            if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = gameObject;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}