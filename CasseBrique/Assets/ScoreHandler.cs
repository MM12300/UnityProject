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

    public void RefreshScore()
    {
        textScore.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
}
