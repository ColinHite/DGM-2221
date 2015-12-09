using UnityEngine;
using System.Collections;

public class AmmoScript : MonoBehaviour {

	//public int currentAmmo;

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			PlayerMovement.currentAmmo += 1;
			Destroy (gameObject);
			Debug.Log("is getting ammo");
		}
	}
}
