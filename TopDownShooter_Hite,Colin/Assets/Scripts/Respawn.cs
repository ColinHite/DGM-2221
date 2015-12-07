using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	
	private PlayerMovement player;
	public GameObject hero;
	public GameObject currentCheckPoint;
	public float respawnDelay;
	
	void Start ()
	{
		player = FindObjectOfType<PlayerMovement>();
	}
	
	public void RespawnPlayer()
	{
		StartCoroutine("RespawnPlayerCo");
	}
	
	public IEnumerator RespawnPlayerCo()
	{
		player.enabled = false;
		player.GetComponent<MeshRenderer>().enabled = false;
		player.GetComponentInChildren<MeshRenderer> ().enabled = false;
		//player.GetComponent<BoxCollider>().enabled = false;
		//player.GetComponent<CircleCollider2D>().enabled = false;
		Debug.Log("Player Respawned");
		yield return new WaitForSeconds(respawnDelay);
		player.transform.position = currentCheckPoint.transform.position;
        player.enabled = true;
        player.GetComponent<MeshRenderer>().enabled = true;
	}
}
