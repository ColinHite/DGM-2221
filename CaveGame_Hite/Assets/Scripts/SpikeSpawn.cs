using UnityEngine;
using System.Collections;

public class SpikeSpawn : MonoBehaviour {

    public Transform deathSpikeSpawn;
    public GameObject spike;
    public float duration = 0.5f;
    private float elapsed;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	void Update ()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= duration)
        {
            Instantiate(spike, deathSpikeSpawn.position, deathSpikeSpawn.rotation);
            elapsed = 0;
            Debug.Log("Made Spike");
        }
    }
}
