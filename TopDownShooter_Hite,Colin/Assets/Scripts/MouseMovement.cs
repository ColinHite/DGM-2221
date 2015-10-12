using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
	
	public Transform Hero;


	// Update is called once per frame
	void FixedUpdate () 
	{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				Hero.transform.forward = new Vector3(hit.point.x, 0, hit.point.z);
			}

			Debug.Log("Is pointing");
	}


}
