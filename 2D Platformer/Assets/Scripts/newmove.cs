using UnityEngine;
using System.Collections;

public class newmove : MonoBehaviour {
	public float speed     = 5.0f;
	public float jumpSpeed = 3.0f;
	public float maxJump   = 3;
	public float jumpCount   = 1;
	bool isGrounded = true;

	// Update is called once per frame
	void Update () 
	{
		var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
		//Jump Action

		if (Input.GetKeyDown (KeyCode.Space) && jumpCount < maxJump)
		{
			GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
			jumpCount++;
		}
		// This is for the double jump

		if (jumpCount > maxJump || isGrounded == false) 
		
		{
			jumpSpeed = 0.0f;
		}

		if (jumpCount > maxJump && isGrounded == true) 
		
		
		{
			jumpSpeed = 0.0f;
			jumpCount = 1;
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "ground") 
		{
			jumpCount = 1;
			jumpSpeed = 7;
		}
	}
}