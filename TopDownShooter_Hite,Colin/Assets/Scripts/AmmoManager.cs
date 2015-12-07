using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {

	public int ammo;

	Text text;
	
	void Start ()
	{
		text = GetComponent<Text>();
	}
	
	
	void Update ()
	{
		text.text = "Ammo: " + PlayerMovement.currentAmmo;
	}
}
