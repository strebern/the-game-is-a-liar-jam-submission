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
               foreach(string tag in lie.LieTags)
                {
                    if(itemTag == tag)
                    {

                    }
                }
            }
        }

        public LiesScript GetCharacterLie()
        {
            return MainLie;
        }
    }
}
