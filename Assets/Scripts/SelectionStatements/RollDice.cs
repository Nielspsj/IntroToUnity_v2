using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDice : MonoBehaviour
{
    //Switch Fall-through cases

    // Start is called before the first frame update
    void Start()
    {
        int diceRoll = 7;

        switch(diceRoll)
        {
            case 7:
                               
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit. the creature goes down!");
                break;
            default:
                Debug.Log("You comepletely missed and fell on your face.");
                break;
        }
    }
}
