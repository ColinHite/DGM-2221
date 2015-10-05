using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject hero;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = hero.transform.position + new Vector3 (0,0,-10);
	}
}
