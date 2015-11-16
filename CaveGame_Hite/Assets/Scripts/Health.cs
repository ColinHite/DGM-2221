using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

   /* public RectTransform healthTransform;
    private float cashedY;
    private float minXValue;
    private float maxXValue;
    private int currentHealth;

    private int CurrentHealth
    {
        get { return currentHealth; }
        set {
            currentHealth = value;
            HandleHealth();
        }
    }

    public int maxHealth;
    public Image visualHealth;
    //public float coolDown;
    //private bool onCD;


	void Start ()
    {
        cashedY = healthTransform.position.y;
        maxXValue = healthTransform.position.x;
        minXValue = healthTransform.position.x - healthTransform.rect.width;
        currentHealth = maxHealth;
        //onCD = false;
	}
	
    private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
    {
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }

    private void HandleHealth()
    {
        float currentXValue = MapValues(currentHealth, 0, maxHealth, minXValue, maxXValue);

        healthTransform.position = new Vector3(currentXValue, cashedY);

       /* if (currentHealth > maxHealth/2)//I have less than 50% health
        {
            visualHealth.color = new Color32((byte)MapValues(currentHealth, maxHealth / 2, maxHealth, 255, 0), 255, 0, 255);
        }
        else //Less than 50%
        {
            visualHealth.color = new Color32(255, (byte)MapValues(currentHealth, 0, maxHealth / 2, 0, 255), 0, 255);

        }*/
    //}

    /*IEnumerator CoolDownDmg()
    {
        onCD = true;
        yield return new WaitForSeconds(coolDown);
        onCD = false;
    }

    void OnCollisionEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("spike") && currentHealth > 0)
        {
           // StartCoroutine(CoolDownDmg());
            CurrentHealth -= 25;
        }
    }*/

}
