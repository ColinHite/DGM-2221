using UnityEngine;
using System.Collections;

public class BatSpawn : MonoBehaviour {

    public Transform batSpawn;
    public GameObject bat;
    public float duration = 0.5f;
    private float elapsed;
    public int[] batAngleSpawn = {-10, 25, 13, -34};

    void Update()
    {
        elapsed += Time.deltaTime;

        int spawnRotationIndex = Random.Range(0, batAngleSpawn.Length);

        if (elapsed >= duration)
        {
            Instantiate(bat, batSpawn.position, batSpawn.rotation);
            elapsed = 0;
            transform.eulerAngles = new Vector3(0, 0, batAngleSpawn[spawnRotationIndex]);
            Debug.Log("Made Bat");
        }
       
    }
        
}
