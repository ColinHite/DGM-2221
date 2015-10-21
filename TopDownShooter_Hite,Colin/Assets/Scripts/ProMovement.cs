using UnityEngine;
using System.Collections;

public class ProMovement : MonoBehaviour {

	public float bulletSpeed;
	public Rigidbody bullet;

	// Gets the bullet item
	void Start () {
		bullet = GetComponent<Rigidbody> ();
	}
	
	// Puts force on the bullet
	void Update () 
	{
		bullet.AddForce (transform.forward * bulletSpeed);
	}
}
