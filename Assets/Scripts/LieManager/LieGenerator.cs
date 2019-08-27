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
            Debug.Log(itemTag);

            int lieRank = Random.Range(0, 6);
            if (lieRank == 5)
                lieRank = Random.Range(3, 6);
            Debug.Log(lieRank);

            foreach (LiesScript lie in _liesList.LiesCompleteList)
            {
                if (lie.LieTags.Contains(itemTag) && lie.LieRank == lieRank)
                {
                    _taggedLieList.Add(lie);
                }
            }


            MainLie = _taggedLieList[Random.Range(0, _taggedLieList.Count)];
            Debug.Log(MainLie.LieText);

        }

        public LiesScript GetCharacterLie()
        {
            return MainLie;
        }
    }
}
