using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionScore : MonoBehaviour
{
    
    private GameObject ScoreHandler;

    [SerializeField]
    private bool player1Goal;

    void Start()
    {
        ScoreHandler  = GameObject.Find("ScoreHandler");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(player1Goal){
            ScoreHandler.GetComponent<ScoreHandler>().IncrementPlayer1Score();
        }
    }
}
