using UnityEngine;
using System.Collections;

public class BulDes : MonoBehaviour 
{


	public float bulletLife = 1.0f;


	void OnCollisionEnter (Collision col)
	{

		if (col.gameObject.tag == ("wall"))
		{Destroy (gameObject);

			Debug.Log ("is hitting wall");
		}
		else if (col.gameObject.tag == "Enemy")
			Destroy (gameObject);

		else
			Destroy (gameObject, bulletLife);

	}
}
