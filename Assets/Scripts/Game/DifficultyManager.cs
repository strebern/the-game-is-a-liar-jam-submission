using UnityEngine;
using TMPro;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private GoblinsSpawnNumber _goblinsSpawnNumber;
    [SerializeField] private TextMeshProUGUI _goblinsNumbersDisplay;

    //CORE

    private void Awake()
    {
        if (_goblinsSpawnNumber._goblinsBaseNumbers == 0)
        {
            _goblinsSpawnNumber._goblinsBaseNumbers = 30;
        }
        _goblinsSpawnNumber._goblinsBaseNumbers = _goblinsSpawnNumber._goblinsBaseNumbers + Random.Range(-5, 6); ;
        _goblinsNumbersDisplay.text = "Goblins to kill : " + _goblinsSpawnNumber._goblinsBaseNumbers;
    }

    //PUBLIC

    public void IncreaseDifficulty()
    {
        _goblinsSpawnNumber._goblinsBaseNumbers += 5;
    }

    public void ResetDifficulty()
    {
        _goblinsSpawnNumber._goblinsBaseNumbers = 30;
        _goblinsNumbersDisplay.text = "Goblins to kill : " + _goblinsSpawnNumber._goblinsBaseNumbers;
    }
}
