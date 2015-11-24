using UnityEngine;
using System.Collections;

public class BatSpawn : MonoBehaviour {

    public int maxBats = 4;
    public int minBats = 0;
    public Transform batSpawn;
    public GameObject bat;
    public float duration = 0.5f;
    private float elapsed;
    public int[] batAngleSpawn = {-10, 25, 13, -34};

    void Update()
    {
        elapsed += Time.deltaTime;

        int spawnRotationIndex = Random.Range(0, batAngleSpawn.Length);

        if (elapsed >= duration && maxBats > minBats)
        {
            Instantiate(bat, batSpawn.position, batSpawn.rotation);
            minBats += 1;
            elapsed = 0;
            transform.eulerAngles = new Vector3(0, 0, batAngleSpawn[spawnRotationIndex]);
            Debug.Log("Made Bat");
        }
       
    }
        
}
