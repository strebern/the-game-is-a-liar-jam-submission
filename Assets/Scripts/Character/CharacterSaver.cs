using Game.Crew;
using UnityEngine;

namespace Game.Character
{
    [DisallowMultipleComponent]
    public class CharacterSaver : MonoBehaviour
    {
        public void SaveCharacter()
        {
            var crewManager = FindObjectOfType<CrewManager>();
            var inventory = GetComponentInChildren<Inventory.Inventory>();
            
            crewManager.AddCharacterToCrew(inventory.Items, "Yo");
        }
    }
}