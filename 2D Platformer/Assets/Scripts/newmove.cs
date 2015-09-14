using UnityEngine;
using System.Collections;

public class newmove : MonoBehaviour {
	public float speed     = 5.0f;
	public float jumpSpeed = 3.0f;
	public float maxJump   = 3;
	public float gravity  = 10.0f;
	public int jumpCount   = 3;

	// Use this for initialization
	void Start () 
	{
	}
	// Update is called once per frame
	void Update () 
	{
		var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
	}
}