using UnityEngine;
using TMPro;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private GoblinsSpawnNumber _goblinsSpawnNumber;
    [SerializeField] private TextMeshProUGUI _goblinsNumbers;

    private int _currentGoblinsSpawnNumber;

    //CORE

    private void Awake()
    {
        _currentGoblinsSpawnNumber = _goblinsSpawnNumber._goblinsBaseNumbers + Random.Range(-5,6); ;
        _goblinsNumbers.text = "Goblins to kill : " + _currentGoblinsSpawnNumber;
    }

    //PUBLIC

    public void IncreaseDifficulty()
    {
        _goblinsSpawnNumber._goblinsBaseNumbers += 5;
    }

    public void ResetDifficulty()
    {
        _goblinsSpawnNumber._goblinsBaseNumbers = 30;
        _goblinsNumbers.text = "Goblins to kill : " + _goblinsSpawnNumber._goblinsBaseNumbers;
    }
}
