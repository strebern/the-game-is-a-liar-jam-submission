using Game.Crew;
using UnityEngine;

namespace Game.Character
{
    [DisallowMultipleComponent]
    public class CharacterSaver : MonoBehaviour
    {
        public void SaveCharacter()
        {
            var inventory = GetComponentInChildren<Inventory.Inventory>();
            if (inventory)
            {
                FindObjectOfType<CrewManager>()?.AddCharacterToCrew(inventory.Items, "Yo");   
            }
        }
    }
}