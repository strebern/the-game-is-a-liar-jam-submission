﻿using System.Collections.Generic;
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

        public void GenerateLie()
        {
            var itemTag = _inventory.GetRandomItemTag();
            
            int lieRank = Random.Range(1, 5);
            if (lieRank == 5)
            {
                lieRank = Random.Range(3, 5);
            }
            
            foreach (var lie in _completeLiesList.Lies)
            {
                if (lie.Tags.Contains(itemTag) && lie.Rank == lieRank)
                {
                    _taggedLieList.Add(lie);
                }
            }

            MainLie = _taggedLieList[Random.Range(0, _taggedLieList.Count)];
            Debug.Log(MainLie.Text);
            
            OnEventGenerated?.Invoke(MainLie.Text);
        }
    }
}
