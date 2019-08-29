using System.Collections.Generic;
using UnityEngine;

namespace Game.Lies
{
    [DisallowMultipleComponent]
    public class LieGenerator : MonoBehaviour
    {
        [HideInInspector] public Lie MainLie;

        [Header("References")]
        [SerializeField] LiesList _completeLiesList;
        [SerializeField] private Inventory.Inventory _inventory;

        [Header("Events")]
        public StringEvent OnEventGenerated;

        private List<Lie> _taggedLieList = new List<Lie>();

        //CORE

        private void Awake()
        {
            GenerateLie();
        }

        //PUBLIC

        public void GenerateLie()
        {
            var itemTag = _inventory.GetRandomItemTag();

            int lieRank = Random.Range(1, 6);
            if (lieRank == 5)
            {
                lieRank = Random.Range(3, 6);
            }

            foreach (var lie in _completeLiesList.Lies)
            {
                if (lie.Tags.Contains(itemTag) && lie.Rank == lieRank)
                {
                    _taggedLieList.Add(lie);
                }
            }

            MainLie = _taggedLieList[Random.Range(0, _taggedLieList.Count)];
        }

        public void DisplayLie()
        {
            OnEventGenerated?.Invoke(MainLie.Text);
        }
    }
}
