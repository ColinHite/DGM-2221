using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5.0f;

	//This is for shooting projectiles
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;


	//This moves the character left right up and down while moving its forward facing position
	void FixedUpdate () {
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
			transform.forward = new Vector3 (Input.GetAxis ("Horizontal"), 0,Input.GetAxis ("Vertical"));
		if (Input.GetButton ("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time * fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}