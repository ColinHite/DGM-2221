using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public static Vector3 targetPos;
	public static float ViewX;
	public static float ViewZ;
	public GameObject Player;
	
	
	// Use this for initialization
	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		ViewX = gameObject.transform.position.x;
		ViewZ = gameObject.transform.position.z;
		targetPos = new Vector3 (Player.transform.position.x, 0, Player.transform.position.z);

		ViewX -= (ViewX - targetPos.x) * 0.1f;
		ViewZ -= (ViewZ - targetPos.z) * 0.1f;
		gameObject.transform.position = new Vector3(ViewX, Player.transform.position.y, ViewZ);
	}
}
