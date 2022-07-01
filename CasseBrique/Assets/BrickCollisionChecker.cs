using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickCollisionChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
        //SceneManager.LoadScene("SampleScene");
    }
}

