using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{

    private PlayerMovement player;
    private Health health;
    public GameObject hero;
    public GameObject nose;
    public GameObject currentCheckPoint;
    public float respawnDelay;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        health = FindObjectOfType<Health>();
    }

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        player.enabled = false;
        health.enabled = false;
        hero.GetComponent<MeshRenderer>().enabled = false;
        //hero.GetComponent<BoxCollider>().enabled = false;
        nose.GetComponent<MeshRenderer>().enabled = false;
        //player.GetComponent<MeshRenderer>().enabled = false;
        //player.GetComponentInChildren<MeshRenderer> ().enabled = false;
        //player.GetComponent<BoxCollider>().enabled = false;
        //player.GetComponent<CircleCollider2D>().enabled = false;
        Debug.Log("Player Respawned");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckPoint.transform.position;
        hero.GetComponent<MeshRenderer>().enabled = true;
        //hero.GetComponent<BoxCollider>().enabled = true;
        nose.GetComponent<MeshRenderer>().enabled = true;
        health.enabled = true;
        player.enabled = true;
        //player.GetComponent<MeshRenderer>().enabled = true;
    }
}
