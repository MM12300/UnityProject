using TMPro;
using UnityEngine;

namespace Assets._Project.ScoreManager
{
    public class ScoreManager
    {
        private int pointPlayer1 = 0;
        private int pointPlayer2 = 0;

        [SerializeField] private GameObject textScore;

        public void IncrementPlayer1Score()
        {
            pointPlayer1++;
            Debug.Log("Player 1 score:" + pointPlayer1);
            RefreshScore();
        }
    
        public void IncrementPlayer2Score()
        {
            pointPlayer2++;
            Debug.Log("Player 1 score:" + pointPlayer2);
            RefreshScore();
        }

        public void RefreshScore()
        {
            textScore.GetComponent<TextMeshProUGUI>().text = pointPlayer1 + ":" + pointPlayer2;
        }
    }
}