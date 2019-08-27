using System.Collections.Generic;
using UnityEngine;

namespace Game.Lies
{
    [CreateAssetMenu(fileName = "LiesList", menuName = "Lies/LiesList", order = 1)]
    public class LiesList : ScriptableObject
    {
        public List<Lie> Lies = new List<Lie>();
    }
}
