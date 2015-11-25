using UnityEngine;
using System.Collections;

public class BatMove : MonoBehaviour {

    //public GameObject batObj;
    public float batSpeed;
    public Rigidbody2D bat;
    // Checks for player
    public Transform playerCheck;
    public float playerCheckRadius;
    public LayerMask whatIsPlayer;
    private bool playerDetect = false;
    // points value
    public int pointsToAdd;
    // Player result
    //public Rigidbody2D player;
    //public float jumpHeight;

    public int BatsToSubtract;

    //bool isGoingLeft = true;
    //bool isGoingUp = true;

    void Start()
    {
        bat = GetComponent<Rigidbody2D>();
        bat.AddForce(-transform.right * batSpeed);
    }

    void FixedUpdate()
    {
        playerDetect = Physics2D.OverlapCircle(playerCheck.position, playerCheckRadius, whatIsPlayer);
    }

    void Update()
    {

        transform.eulerAngles = new Vector3(0, 0, 0);

        if (playerDetect == true)
        {
            //player.velocity = new Vector2(jumpHeight, player.velocity.y);
            Destroy(gameObject);
            ScoreManager.AddPoints(pointsToAdd);
            BatSpawn.AddBats(BatsToSubtract);
        }

        //Bat Flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);

        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

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
