using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randomVector = new Vector3(Random.Range(-1f, 1f), 0, 1);

        if (Input.GetKey(KeyCode.Space))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(randomVector * speed);
        }
    }
}
