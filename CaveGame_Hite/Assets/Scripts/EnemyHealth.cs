using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float maxHealth = 100;
    public float currentHealth = 0;
    private bool damaged;

    // Use this for initialization
    void Start ()
    {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
}
