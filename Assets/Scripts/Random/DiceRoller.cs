using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceRoller : MonoBehaviour
{
    public TMP_Text diceText;
    public TMP_Text diceText2;
    private int diceResult;
    private int diceResult2;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Terningkast.
            DiceThrow();
        }
    }

    //Randomly select a result within a range. Print in console.
    private void DiceThrow()
    {
        diceResult = Random.Range(1, 7);
        diceText.text = diceText.ToString();
        diceResult2 = Random.Range(1, 7);
        diceText2.text = diceText2.ToString();

        if (diceResult < diceResult2)
        {
            Debug.Log("player 2 won");

        }
        else if (diceResult > diceResult2)
        {
            Debug.Log("player 1 won");

        }
    }
}
