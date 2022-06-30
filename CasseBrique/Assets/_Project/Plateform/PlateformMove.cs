using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMove : MonoBehaviour
{

    [SerializeField] 
    private float speed;
    
    [SerializeField]
    private bool player1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right * horizontal + Vector3.up * vertical);

        var positionY = transform.position.y;
        

        if ((Input.GetKey(KeyCode.LeftArrow)))
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.left*0.1f);
        }
    
        if ((Input.GetKey(KeyCode.RightArrow)))
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right*0.1f);
        }
        

        var position = transform.position;

        if (position.y > 5f)
        {
            position.y = 5f;
        }

        if (position.y < -4f)
        {
            position.y = -4f;
        }

        transform.position = position;
    }
}
