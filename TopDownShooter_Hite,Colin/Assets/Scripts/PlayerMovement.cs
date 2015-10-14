using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5.0f;

	public GameObject shot;
	public Transform shotSpawn;
	public float duration = 0.5f;
	private float elapsed;
	//private float nextFire;


	//This moves the character left right up and down while moving its forward facing position
	void FixedUpdate () {
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
			
		elapsed += Time.deltaTime;
		if (Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.W) ||Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.D))
			transform.forward = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

		if (Input.GetButton ("Fire1") && elapsed >= duration) 
		{
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			elapsed = 0;
		}
	}
}