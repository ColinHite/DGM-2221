using UnityEngine;
using System.Collections;

public class RespawnGuy : MonoBehaviour {
	
	private Vector3 spawn;

	void Start ()

	{
		spawn = transform.position;
	}

	void OnCollisionEnter(Collision other)

	{
		if (other.transform.tag == "killBox") 
		{
			transform.position = spawn;
		}
	}
}