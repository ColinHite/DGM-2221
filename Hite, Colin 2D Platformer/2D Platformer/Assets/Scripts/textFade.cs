using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textFade : MonoBehaviour {

	public Text welcome;
	public float fadeSpeed = 5f;
	public bool entrance;
	public GameObject houseOne;

	void Awake ()
	{
		welcome = houseOne.GetComponentInChildren<Text> ();
		welcome.color = Color.clear;
	}

	// Update is called once per frame
	void Update () 
	{
		ColorChange ();
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			entrance = true;
		}
	}

	
	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			entrance = false;
		}
	}

	void ColorChange ()
	{
		if (entrance) 
		{
			welcome.color = Color.Lerp (welcome.color, Color.white, fadeSpeed * Time.deltaTime);
		}

		if (!entrance) 
		{
			welcome.color = Color.Lerp (welcome.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}

}
