using UnityEngine;
using System.Collections;

public class NewHealth : MonoBehaviour {

    public float maxHealth = 100;
    public float currentHealth = 0;
    public Respawn respawn;
    public GameObject healthBar;

    public GameObject killScreen;

	void Start ()
    {
        respawn = FindObjectOfType<Respawn> ();
        currentHealth = maxHealth;
        InvokeRepeating("decreseHealth", 1f, 1f);
	}

   
    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == ("spike"))
        {
            currentHealth -= 25;
            Debug.Log("Got Hit took damage");
        }

        if (currentHealth == 0)
        {
            killScreen.SetActive(true);
            respawn.RespawnPlayer();
        }
    }

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
