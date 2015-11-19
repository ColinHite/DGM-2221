using UnityEngine;
using System.Collections;

public class DodgePoints : MonoBehaviour
{

    public int pointsToAdd;
    public static int hitLog = 1;

    // Pass function to restart multiplier
    public static void Multiplier(int multi = 1)
    {
        hitLog = multi;
    }

    //Adds points when Spike hits back wall and multiplies the score for each one
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == ("spike"))
        {
            Debug.Log("GotPoints");
            ScoreManager.AddPoints(pointsToAdd * hitLog);
            hitLog += 1;
        }
    }
}
