using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5.0f;

	//public GameObject PlayerRes;
	//public GameObject Lvl;
	public GameObject shot;
	public Transform shotSpawn;
	public float duration = 0.5f;
	private float elapsed;
	//private float nextFire;
	public int pointsToAdd = 25;
	//Ammunition
	public static int maxAmmo = 5;
	public static int currentAmmo;
	

	void Start ()
	{
		currentAmmo = maxAmmo;
	}
	
	//This moves the character left right up and down while moving its forward facing position
	void FixedUpdate () {

		//Movement
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		{
			GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		}
			
		elapsed += Time.deltaTime;

		//Rotation forward
		if (Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.W) ||Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow))
			transform.forward = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

		//Is shooting
		if (Input.GetButton ("Fire1") && elapsed >= duration && currentAmmo > 0) 
		{
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			elapsed = 0;
			currentAmmo -= 1;
		}
		if (currentAmmo > 10)
			currentAmmo = 10;
	}
	void OnCollisionEnter (Collision col)
	{

		//Death Script
		//if (col.transform.tag == "Bolt")
		//{
		//	transform.position = PlayerRes.transform.position;
		//}
		/*else if (col.transform.tag == "Lvl")
		{
			transform.position = Lvl.transform.position;
		}*/
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "coin") 
		{
			ScoreManager.AddPoints(pointsToAdd);
			Destroy(GameObject.FindWithTag("coin"));
		}
		if (col.gameObject.tag == "ammo") 
		{
			currentAmmo += 1;
			Destroy(GameObject.FindWithTag("ammo"));
		}
	}
}