using UnityEngine;
using System.Collections;

public class HeroMove : MonoBehaviour {
    //Player Movement
    public float moveSpeed;
    public float jumpHeight;

    public float moveVelocity;

    //Ground Check
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    //Double Jump
    private bool doubleJumped;

    //Player Animation
    //private Animator anim;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Update()
    {

        //Stops player from sticking to the wall
        moveVelocity = 0f;

        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            //Debug.Log("I moved right");
            moveVelocity = moveSpeed;
        }
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            //Debug.Log("I moved left");
            moveVelocity = -moveSpeed;
        }
        //Move Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            //Debug.Log("I moved right");
            moveVelocity = moveSpeed;
        }
        //Move Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            //Debug.Log("I moved left");
            moveVelocity = -moveSpeed;
        }

        //Stops Player from sticking to the wall
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            //Debug.Log("I jumped");
        }

        //Player Walk Animation
        //anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        //Player Flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);

        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);

        //Double Jump
        if (grounded)
            doubleJumped = false;

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            doubleJumped = true;
            //Debug.Log("I jumped twice");
        }

        //Player Jump Animation
        //anim.SetBool("Grounded", grounded);
    }
    /*void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bat")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }*/
}
