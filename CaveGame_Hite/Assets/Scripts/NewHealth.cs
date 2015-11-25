using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewHealth : MonoBehaviour {
    // Health and respawn
    //private NewHealth health;
    private SpikeSpawn spikeSpawn;
    public float maxHealth = 100;
    public float currentHealth = 0;
    public Respawn respawn;
    public GameObject healthBar;

    //--Damage Flash
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public Image damageImage;
    bool damaged = false;

    // Death screen
    public GameObject killScreen;
    // point multiplier
    public int hitLog;

	void Start ()
    {
        spikeSpawn = FindObjectOfType<SpikeSpawn>();
        respawn = FindObjectOfType<Respawn> ();
        currentHealth = maxHealth;
        InvokeRepeating("decreseHealth", 1f, 1f);
	}

    void Update()
    {
        if (damaged == true)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
        //Debug.Log("Flashed Damage Image");
    }

   //Makes the player lose health and upon 0 health lose the game
    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == ("spike") || col.gameObject.tag == ("bat"))
        {
            damaged = true;
            currentHealth -= 10;

            //Handles point multiplier loss
            DodgePoints.Multiplier(hitLog = 1);
            Debug.Log("Lost Multiplier");
            Debug.Log("Got Hit took damage");
        }

        if (currentHealth == 0)
        {
            gameObject.SetActive(false);
            spikeSpawn.enabled = false;
            //enabled = false;
            //health.enabled = false;
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
