using UnityEngine;

namespace Assets._Project.ScoreManager
{
    public class OnCollisionScore
    {
        [SerializeField]
        private GameObject ScoreManager;

        [SerializeField]
        private bool player1Goal;

        [SerializeField]
        private bool player2Goal;


        private void OnCollisionEnter(Collision collision)
        {
            if(player1Goal){
                ScoreManager.GetComponent<ScoreManager>().IncrementPlayer1Score();
            }
        
            if(player2Goal){
                ScoreManager.GetComponent<ScoreManager>().IncrementPlayer2Score();
            }
        }
    }
}