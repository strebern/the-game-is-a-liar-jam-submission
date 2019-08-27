using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Inventory/Items", order = 1)]
public class ItemScript : ScriptableObject
{
    public string ItemName;
    public string TAG;
    public Sprite ItemSprite;
}
