using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Lies
{
    public class LieGenerator : MonoBehaviour
    {
        [HideInInspector] public Lie MainLie;

        [Header("References")]
        [SerializeField] LiesList _completeLiesList;

        private List<Lie> _taggedLieList = new List<Lie>();

        public void GenerateLie(string itemTag)
        {
            //Debug.Log(itemTag);

            int lieRank = Random.Range(0, 6);
            if (lieRank == 5)
                lieRank = Random.Range(3, 6);
            Debug.Log(lieRank);

            foreach (var lie in _completeLiesList.Lies)
            {
                if (lie.Tags.Contains(itemTag) && lie.Rank == lieRank)
                {
                    _taggedLieList.Add(lie);
                }
            }

            MainLie = _taggedLieList[Random.Range(0, _taggedLieList.Count)];
            Debug.Log(MainLie.Text);
        }
    }
}
