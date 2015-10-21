using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {


	//Movement and tracking
	public float speed = 5.0f;
	public bool inRange = false;
	public GameObject hero;
	public Transform LockOn;


	//For the enemy Respawn
	public GameObject EnemyRes;


	//For the bullet
	public GameObject shot;
	public Transform shotSpawn;
	public float duration = 0.5f;

	//Next bullet timespan
	private float elapsed;



	void Update()
	{

		//Movement and Tracking
		if (inRange == true)
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, step);
			transform.LookAt (LockOn);
		}

		//Bullet creation
		if (inRange == true && elapsed >= duration) 
		{
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			elapsed = 0;
		}
	}

	//Sets the float for time between bullets
	void FixedUpdate ()
	{
		elapsed += Time.deltaTime;
	}

	//Bullet Detection
	void OnCollisionEnter (Collision col)
	{
		if (col.transform.tag == "Bolt")
		{
			transform.position = EnemyRes.transform.position;
			Debug.Log ("Is hitting red box");
		}

	}


	//Starts Enemy movement
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{

			inRange = true;
		}

	}


	//Stops Enemy Movement
	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			inRange = false;
		}
	}
}
