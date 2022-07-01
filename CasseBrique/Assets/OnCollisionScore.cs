using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionScore : MonoBehaviour
{
    
    private GameObject ScoreHandler;

    void Start()
    {
        ScoreHandler  = GameObject.Find("ScoreHandler");
    }


    private void OnCollisionEnter(Collision collision)
    {
        
            ScoreHandler.GetComponent<ScoreHandler>().IncrementScore();
        
    }
}
