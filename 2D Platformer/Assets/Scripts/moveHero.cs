using UnityEngine;
using System.Collections;

public class moveHero : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = 10f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime, 0f);
	}

}

