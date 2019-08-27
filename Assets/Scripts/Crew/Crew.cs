using System.Collections.Generic;
using Game.Character;
using UnityEngine;

namespace Game.Crew
{
    [CreateAssetMenu(fileName = "Crew", menuName = "Characters/Crew", order = 0)]
    public class Crew : ScriptableObject
    {
        public int MaxCrewSize;
        public List<Character.Character> Members;
    }
}