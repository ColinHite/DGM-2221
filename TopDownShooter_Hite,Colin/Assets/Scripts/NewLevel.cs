using UnityEngine;
using System.Collections;

public class NewLevel : MonoBehaviour {


	public GameObject Lvl;
	public GameObject player;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) 
	{
		if (other.transform.tag == "Player") 
		{
			player.transform.position = Lvl.transform.position;
		}
	}
}
