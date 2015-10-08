using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed = 5.0f;
	public bool inRange = false;
	public GameObject hero;
	public Transform LockOn;
	void Update()
	{
		if (inRange == true)
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, step);
			transform.LookAt (LockOn);
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			inRange = true;
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			inRange = false;
		}
	}
}
