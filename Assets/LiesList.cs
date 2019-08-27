using UnityEngine;

[CreateAssetMenu(fileName = "LiesList", menuName = "Lies/LiesList", order = 1)]
public class LiesList : ScriptableObject
{
    public LiesScript[] Lies;
}
