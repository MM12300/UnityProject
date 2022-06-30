using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left*Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right*Time.deltaTime*speed);
        }
    }
}
