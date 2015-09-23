using UnityEngine;
using System.Collections;

public class RespawnGuy : MonoBehaviour {
	
	public GameObject spawn;

	void Start ()

	{

	}

	void OnCollisionEnter(Collision other)

	{
		if (other.transform.tag == "killBox") 
		{
			transform.position = spawn.transform.position;
		}
	}
}