using System.Collections.Generic;
using UnityEngine;

namespace Game.Lies
{
    [CreateAssetMenu(fileName = "Lie", menuName = "Lies/Lie", order = 1)]
    public class Lie : ScriptableObject
    {
        public int Rank;
        public string Text;
        public List<string> Tags;
    }
}
