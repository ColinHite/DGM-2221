using UnityEngine;
using System.Collections;

public class SpikeMoveDes : MonoBehaviour {

    public float spikeLife = 1.0f;
    public float spikeSpeed;
    public Rigidbody2D spike;

	void Start ()
    {
        spike = GetComponent<Rigidbody2D>();
	}
	

	void Update ()
    {
        spike.AddForce(transform.up * spikeSpeed);

        Destroy(gameObject, spikeLife);
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == ("wall"))
        {
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        else
            Debug.Log("Is Dead");

    }
}
