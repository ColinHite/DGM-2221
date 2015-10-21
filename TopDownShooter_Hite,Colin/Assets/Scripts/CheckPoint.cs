using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public GameObject Lvl;
	public GameObject player;


	//Moves player to next level

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			player.transform.position = Lvl.transform.position;
		}
	}
}
