using UnityEngine;
using System.Collections;

public class rotationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			transform.forward = new Vector3(0f,0f,-1f);	
		}
		if(Input.GetKeyDown (KeyCode.D))
		{
			transform.forward = new Vector3(0f,0f,1f);	
		}
		if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
			transform.forward = new Vector3(0f,0f,-1f);	
		}	
		if(Input.GetKeyDown (KeyCode.RightArrow))
		{
			transform.forward = new Vector3(0f,0f,1f);	
		}
	}

}
