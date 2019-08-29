using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Crew;
using Game.Character;
using Game.Inventory;
using TMPro;

public class TeamPointsCalculator : MonoBehaviour
{
    [SerializeField] private Crew _crew;
    [SerializeField] private TextMeshProUGUI _pointsDisplay;
    [SerializeField] private Highscore _highscore;
    [SerializeField] private TextMeshProUGUI _highscoreDisplay;

    private void Awake()
    {
        _highscore.HighScore = 0;
    }


    public int  GetTeamPoints()
    {
        var totalPoints = 0;

        foreach (Character character in _crew.Members)
        {
            var itemsMatchNumber = 0;
            var pointsMultiplier = 0;
            var lieRank = character.Lie.Rank;

            foreach (Item item in character.Items)
            {
                foreach (string tag in character.Lie.Tags)
                {
                    if (tag == item.name)
                    {
                        itemsMatchNumber++;
                    }
                }
            }

            switch (itemsMatchNumber)
            {
                case 0:
                    pointsMultiplier = 0;
                    break;
                case 1:
                    pointsMultiplier = 2;
                    break;
                case 2:
                    pointsMultiplier = 4;
                    break;
                case 3:
                    pointsMultiplier = 6;
                    break;
            }
            totalPoints += pointsMultiplier * lieRank;
            Debug.Log("Lie rank is :  " + lieRank);
            Debug.Log("itemsMatchNumber is :  " + itemsMatchNumber + "  And provide a multiplier of : " + pointsMultiplier);
            Debug.Log("TotalPoints increased by :  " + pointsMultiplier * lieRank);
        }
        Debug.Log("Total points for the crew is : " + totalPoints);
        return totalPoints;
    }

    public void CalculateTeamPoints()
    {
        var totalPoints = 0;

        foreach (Character character in _crew.Members)
        {
            var itemsMatchNumber = 0;
            var pointsMultiplier = 0;
            var lieRank = character.Lie.Rank;

            foreach (Item item in character.Items)
            {
                foreach (string tag in character.Lie.Tags)
                {
                    if (tag == item.name)
                    {
                        itemsMatchNumber++;
                    }
                }
            }

            switch (itemsMatchNumber)
            {
                case 0:
                    pointsMultiplier = 0;
                    break;
                case 1:
                    pointsMultiplier = 2;
                    break;
                case 2:
                    pointsMultiplier = 4;
                    break;
                case 3:
                    pointsMultiplier = 6;
                    break;
            }
            totalPoints += pointsMultiplier * lieRank;
            Debug.Log("Lie rank is :  " + lieRank);
            Debug.Log("itemsMatchNumber is :  " + itemsMatchNumber + "  And provide a multiplier of : " + pointsMultiplier);
            Debug.Log("TotalPoints increased by :  " + pointsMultiplier * lieRank);
        }
        Debug.Log("Total points for the crew is : " + totalPoints);
        if(_highscore.HighScore < totalPoints)
        {
            _highscore.HighScore = totalPoints;
            _highscoreDisplay.text = "Highscore : " + _highscore.HighScore.ToString();
        }

        _pointsDisplay.text = "Points : " + totalPoints.ToString();
    }
}
