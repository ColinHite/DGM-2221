using UnityEngine;
using System.Collections;

public class deathRestart : MonoBehaviour {
	private Vector3 initialPos;
	private Quaternion initialRotation;
	bool 

	void Start () 
	{
		initialPos = transform.position;
		initialRotation = transform.rotation;
	}

	void Update () 
	{
		if(gameObject.transform.position.x
	}

	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
}
