using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.forward = new Vector3 (0f, 0f, 0f);	
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.forward = new Vector3 (0f, 0f, 0f);	
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.forward = new Vector3 (0f, 0f, 0f);	
		}	
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.forward = new Vector3 (0f, 0f, 0f);	
		}
	}
}