using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Win : MonoBehaviour {

	public GameObject win;
	public GameObject hero;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Player") {
			win.SetActive (true);
			hero.SetActive (false);
		}
	}
}
