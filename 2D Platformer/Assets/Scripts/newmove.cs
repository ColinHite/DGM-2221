using UnityEngine;
using System.Collections;

public class newmove : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;
	/*public float speed     = 5.0f;
	public float jumpSpeed = 3.0f;
	public float maxJump   = 3;
	public float velocity  = 10.0f;
	public int jumpCount   = 3;
	bool isGrounded = true;
*/
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.AddForce (transform.("Horizontal") * thrust);

	}
	
	
	
	
	
	
	
	
}
	
	
	/*{
		var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		{
			GetComponent<Rigidbody> ().AddForce (new Vector3 (move * speed * Time.deltaTime));
		}
	}
}*/
