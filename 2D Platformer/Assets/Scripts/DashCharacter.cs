using UnityEngine;
using System.Collections;

public class DashCharacter : MonoBehaviour {
	public float dashSpeed = 5.0f;

	void Start () 
	{
	
	}

	void Update()
	{
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		{
			if (Input.GetKeyDown (KeyCode.F)) 
			{
				GetComponent<Rigidbody> ().position += move * dashSpeed;
				Debug.Log ("Dashed");
			}
		}
	}
}
