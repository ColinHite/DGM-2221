using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public RespawnGuy respawnGuy;

	// Use this for initialization
	void Start () 
	{
		respawnGuy = FindObjectOfType<RespawnGuy> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player") 
		{
			respawnGuy.spawn = gameObject;
		}
	}
}
