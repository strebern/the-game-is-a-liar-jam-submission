using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Lies
{
    public class LieGenerator : MonoBehaviour
    {
       [HideInInspector] public LiesScript MainLie;

        [SerializeField] LiesList _liesList;

        private List<LiesScript> _taggedLieList = new List<LiesScript>();


        public void GenerateLie(string itemTag)
        {
            foreach(LiesScript lie in _liesList.Lies)
            {
               // Debug.LogError(lie.LieTags);
            }
        }
    }
}
