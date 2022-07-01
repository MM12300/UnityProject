using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private GameObject textScore;

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score:" + score);
        RefreshScore();
    }

    public void IncrementScoreBonus()
    {
        score += 2;
        Debug.Log("Score:" + score);
        RefreshScore();
    }

    public void RefreshScore()
    {
        textScore.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
    public bool Winner()
    {
        bool winner = false;

        if (score == 20)
        {
            winner = true;
        }

        return winner;
    }
}
