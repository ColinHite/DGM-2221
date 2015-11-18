using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    private HeroMove player;
    public GameObject currentCheckPoint;
    public float respawnDelay;

	void Start ()
    {
        player = FindObjectOfType<HeroMove>();
    }

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        Debug.Log("Player Respawned");
        yield return new WaitForSeconds(respawnDelay);
        /*player.transform.position = currentCheckPoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;*/
    }
}
