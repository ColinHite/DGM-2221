using UnityEngine;
using System.Collections;

public class NewLevel : MonoBehaviour 
{

	public GameObject Winner;

	void OnTriggerEnter (Collider col) 
	{
		if (col.transform.tag == "Player")
			{
			transform.position = Winner.transform.position;
			}
	}
}
