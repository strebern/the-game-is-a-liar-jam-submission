using System.Collections.Generic;
using UnityEngine;

namespace Game.Lies
{
    [CreateAssetMenu(fileName = "Lie", menuName = "Lies/Lie", order = 1)]
    public class LiesScript : ScriptableObject
    {
        public int LieRank;
        public string LieText;
        public List<string> LieTags = new List<string>();
    }
}
