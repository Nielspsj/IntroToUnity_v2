using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int maxHealth = 100;
    public int damageTaken;
    private int currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    //Subtract damage from health. Kill if no health left.
    public void TakeDamage()
    {
        currentHealth -= damageTaken;
        Debug.Log("currentHealth: " + currentHealth);
        if(currentHealth <= 0)
        {
            Debug.Log("Dead");
            gameObject.SetActive(false);
        }
    }
    private void StopToShoot()
    {
    }
}
