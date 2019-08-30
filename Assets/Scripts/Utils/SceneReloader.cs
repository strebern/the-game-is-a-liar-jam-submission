using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Utils
{
    public class SceneReloader : MonoBehaviour
    {
        public void ReloadCurrentScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}