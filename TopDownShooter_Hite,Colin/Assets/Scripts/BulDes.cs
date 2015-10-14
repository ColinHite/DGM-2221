using UnityEngine;
using System.Collections;

public class BulDes : MonoBehaviour 
{


	public float bulletLife = 1.0f;
	void Update()
	{
		Destroy (gameObject, bulletLife);
	}

	void OnCollisionEnter (Collision col)
	{

		if (col.gameObject.tag == ("wall"))
		{Destroy (gameObject);

			Debug.Log ("is hitting wall");
		}
		else if (col.gameObject.tag == "Enemy")
			Destroy (gameObject);
		else if(col.gameObject.tag == "Player")
			Destroy (gameObject);
		else 
				Debug.Log ("Is dead");

	}
}
