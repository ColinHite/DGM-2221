using UnityEngine;
using System.Collections;

public class SpikeSpawn : MonoBehaviour {

    //public NewHealth health;
    //public GameObject hero;
    public Transform deathSpikeSpawn;
    public GameObject spike;
    public float duration = 0.5f;
    private float elapsed;

    // Use this for initialization
    void Start ()
    {
        //health = FindObjectOfType<NewHealth>();
	}
	
	void Update ()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= duration /*&& health == enabled*/)
        {
            Instantiate(spike, deathSpikeSpawn.position, deathSpikeSpawn.rotation);
            elapsed = 0;
            Debug.Log("Made Spike");
        }
    }
}
