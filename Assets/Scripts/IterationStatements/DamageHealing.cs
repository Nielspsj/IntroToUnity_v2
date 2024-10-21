using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DamageHealing : MonoBehaviour
{
    public TMP_Text playerHealthText;
    public int maxHealth = 100;

    private int playerHealthAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        //TakeDamageOverTime();
        StartCoroutine(HealOverTime());

    }

    private void TakeDamageOverTime()
    {
        playerHealthAmount = 10;
        playerHealthText.text = playerHealthAmount.ToString();

        while (playerHealthAmount > 0)
        {
            Debug.Log("Still alive!");
            playerHealthAmount--;
            playerHealthText.text = playerHealthAmount.ToString();
        }
        Debug.Log("Player KO'd...");
    }

    private IEnumerator HealOverTime()
    {
        int playerHealthAmount = 10;
        playerHealthText.text = playerHealthAmount.ToString();

        while (playerHealthAmount < maxHealth)
        {
            Debug.Log("Healing! HP : " + playerHealthAmount);
            yield return new WaitForSeconds(2.5f);
            playerHealthAmount++;
            playerHealthText.text = playerHealthAmount.ToString();

        }
        Debug.Log("Fully healed <3");
    }

   
}
