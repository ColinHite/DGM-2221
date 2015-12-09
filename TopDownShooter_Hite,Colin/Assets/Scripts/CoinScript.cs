using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public int pointsToAdd = 25;

	void Start () 
	{
	
	}
	

	void Update () 
	{
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			ScoreManager.AddPoints (pointsToAdd);
			Destroy (gameObject);
		}

	}
}
