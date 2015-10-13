using UnityEngine;
using System.Collections;

public class ProMovement : MonoBehaviour {

	public float bulletSpeed;
	public Rigidbody bullet;

	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		bullet.AddForce (transform.forward * bulletSpeed);
	}
}
