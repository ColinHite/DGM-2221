using UnityEngine;
using System.Collections;

public class SpikeMoveDes : MonoBehaviour {

    public float spikeLife = 1.0f;
    public int spikeSpeed;
    public Rigidbody2D spike;
    //public float speedMul = 1.0f;

	void Start ()
    {
        spike = GetComponent<Rigidbody2D>();
	}
	

	void Update ()
    {
        spike.velocity = new Vector2(-spikeSpeed, spike.velocity.y);
        //spike.velocity = transform.up * spikeSpeed;
        /*speedMul += 1;
        spikeSpeed = speedMul * 0.01f;
        */
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
