using System.Collections;
using UnityEngine;

namespace Game.Utils
{
    [DisallowMultipleComponent]
    public class SelfDestroyer : MonoBehaviour
    {
        // PUBLIC
        public void DestroySelfAfterXSeconds(float x)
        {
            StartCoroutine(DestroySelfAfterXSecondsRoutine(x));
        }
        public void DestroySelf()
        {
            Destroy(gameObject);
        }
        
        // PRIVATE

        private IEnumerator DestroySelfAfterXSecondsRoutine(float x)
        {
            yield return new WaitForSeconds(x);
        }
    }
}