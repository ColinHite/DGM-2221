using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour {

	public static Vector3 targetPos;
	public static float ViewX;
	public static float ViewY;
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
		ViewY = gameObject.transform.position.y;
		targetPos = new Vector3 (Player.transform.position.x, Player.transform.position.y, 0);

		ViewX -= (ViewX - targetPos.x) * 0.1f;
		ViewY -= (ViewY - targetPos.y) * 0.1f;
		gameObject.transform.position = new Vector3(ViewX, ViewY, gameObject.transform.position.z);
	}
}
