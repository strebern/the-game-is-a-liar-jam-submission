using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Highscore", menuName = "Game/Highscore", order = 1)]
public class Highscore : ScriptableObject
{
    public int HighScore;

    private void Awake()
    {
        HighScore = 0;
    }
}
