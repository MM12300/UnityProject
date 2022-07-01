using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int pointPlayer1 = 0;

    [SerializeField] private GameObject textScore;

    public void IncrementPlayer1Score()
    {
        pointPlayer1++;
        Debug.Log("Player 1 score:" + pointPlayer1);
        RefreshScore();
    }

    public void RefreshScore()
    {
        textScore.GetComponent<TextMeshProUGUI>().text = "Score: " + pointPlayer1;
    }
}
