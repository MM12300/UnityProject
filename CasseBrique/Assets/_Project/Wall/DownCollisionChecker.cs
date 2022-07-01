using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DownCollisionChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
