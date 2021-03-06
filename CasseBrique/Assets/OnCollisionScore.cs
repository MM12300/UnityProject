using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisionScore : MonoBehaviour
{
    [SerializeField] private bool bonus;

    private GameObject ScoreHandler;

    void Start()
    {
        ScoreHandler  = GameObject.Find("ScoreHandler");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (bonus)
        {
            ScoreHandler.GetComponent<ScoreHandler>().IncrementScoreBonus();

        } else
        {
            ScoreHandler.GetComponent<ScoreHandler>().IncrementScore();
        }
        if (ScoreHandler.GetComponent<ScoreHandler>().Winner())
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }
}
