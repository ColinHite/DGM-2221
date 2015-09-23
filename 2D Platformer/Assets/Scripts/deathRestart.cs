using UnityEngine;
using System.Collections;

public class deathRestart : MonoBehaviour {
	public GameObject respawnPrefab;
	public GameObject[] respawns;
	void Start () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if(respawns == null)
			respawns = GameObject.FindGameObjectsWithTag("Player");
		
		foreach (GameObject respawn in respawns)
		{
			Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
		}
		GetComponent<MeshRenderer> ().enabled = false;
	}
}

