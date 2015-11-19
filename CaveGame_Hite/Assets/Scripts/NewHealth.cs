using UnityEngine;
using System.Collections;

public class NewHealth : MonoBehaviour {
    // Health and respawn
    public float maxHealth = 100;
    public float currentHealth = 0;
    public Respawn respawn;
    public GameObject healthBar;
    // Death screen
    public GameObject killScreen;
    // point multiplier
    public int hitLog;

	void Start ()
    {
        respawn = FindObjectOfType<Respawn> ();
        currentHealth = maxHealth;
        InvokeRepeating("decreseHealth", 1f, 1f);
	}

   //Makes the player lose health and upon 0 health lose the game
    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == ("spike"))
        {
            currentHealth -= 25;

            //Handles point multiplier loss
            DodgePoints.Multiplier(hitLog = 1);
            Debug.Log("Lost Multiplier");

            Debug.Log("Got Hit took damage");
        }

        if (currentHealth == 0)
        {
            killScreen.SetActive(true);
            respawn.RespawnPlayer();
        }
    }
    // modifies the health bar position
    void decreseHealth()
    {
        float calc_Health = currentHealth / maxHealth;
        SetHealthBar(calc_Health);
    }

    void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

}
