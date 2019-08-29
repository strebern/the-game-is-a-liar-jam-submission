using Game.Crew;
using Game.Lies;
using UnityEngine;

namespace Game.Character
{
    [DisallowMultipleComponent]
    public class CharacterSaver : MonoBehaviour
    {
        public void SaveCharacter()
        {
            var inventory = GetComponentInChildren<Inventory.Inventory>();
            var lie = GetComponentInChildren<LieGenerator>().MainLie;
            if (inventory)
            {
                FindObjectOfType<CrewManager>()?.AddCharacterToCrew(inventory.Items, "Yo", lie);   
            }
        }
    }
}