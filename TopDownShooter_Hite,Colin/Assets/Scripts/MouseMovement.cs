using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
	

	//This Script was for the Hero to follow the mouse using a Raycast.
	//
	//
	//
	//
	//






	public Transform Hero;


	//Creates Ray toward ground
	void FixedUpdate () 
	{
			
		//Sets movement to mouse pos.
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				Hero.transform.forward = new Vector3(hit.point.x, 0, hit.point.z);
			}

			Debug.Log("Is pointing");
	}


}
