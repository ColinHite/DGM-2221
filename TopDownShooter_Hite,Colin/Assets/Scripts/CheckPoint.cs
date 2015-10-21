using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public GameObject Lvl;


	//Moves player to next level

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			transform.position = Lvl.transform.position;
		}
	}
}
