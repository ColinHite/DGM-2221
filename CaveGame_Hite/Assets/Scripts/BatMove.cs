using UnityEngine;
using System.Collections;

public class BatMove : MonoBehaviour {

    //public GameObject batObj;
    public float batSpeed;
    public Rigidbody2D bat;
    bool isGoingLeft = true;
    bool isGoingUp = true;

    void Start()
    {
        bat = GetComponent<Rigidbody2D>();
        bat.AddForce(-transform.right * batSpeed);
    }


    void Update()
    {

        transform.eulerAngles = new Vector3(0, 0, 0);

        /*if (isGoingLeft == true)
        {
            bat.AddForce(-transform.right * batSpeed);
            Debug.Log("is moving left");
        }
        if (isGoingLeft == false)
        {
            bat.AddForce (transform.right * batSpeed);
            Debug.Log("is moving right");
        }
    }
        /*if (isGoingUp == true)
        {
            bat.velocity = transform.up * batSpeed;
            Debug.Log("is moving up");
        }
        if (isGoingUp == false)
        {
            bat.velocity = -transform.up * batSpeed;
            Debug.Log("is moving down");
        }
        
    }

    void OnTriggerEnter2D (Collider2D col)
    {
       if (col.gameObject.tag == "BBWall")
        {
            isGoingLeft = false;
        }
       if (col.gameObject.tag == "BFWall")
        {
            isGoingLeft = true;
        }
       if (col.gameObject.tag == "BUWall")
        {
            isGoingUp = false;
        }
       if (col.gameObject.tag == "BDWall")
        {
            isGoingUp = true;
        }*/
    }
}
