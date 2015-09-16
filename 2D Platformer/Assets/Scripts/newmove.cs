using UnityEngine;
using System.Collections;

public class newmove : MonoBehaviour {
	public float speed     = 5.0f;
	public float jumpSpeed = 3.0f;
	public float maxJump   = 2;
	public int jumpCount   = 0;
	public bool isGrounded = true;
	public float jumpForce = 10.00f;

	// Update is called once per frame
	void Update () 
	{
		var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
		//Jump Action

		
		if (Input.GetKeyDown (KeyCode.Space) && maxJump < 3) {
			GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
			jumpCount++;
		}
		// This is for the double jump
		if (jumpCount > maxJump || isGrounded == false) {
			jumpSpeed = 0.0f;
		}
		if (jumpCount > maxJump && isGrounded == true) {
			jumpSpeed = 0.0f;
			jumpCount = 1;
		}
	}
	void OnCollisionEnter (Collision greg)
		{
			isGrounded = true;
		}
}