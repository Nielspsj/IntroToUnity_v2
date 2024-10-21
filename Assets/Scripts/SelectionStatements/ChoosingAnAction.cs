using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingAnAction : MonoBehaviour
{
    //Switch statement. Predict, Run, Investigate

    // Start is called before the first frame update
    void Start()
    {
        string characterAction = "Attack";

        switch(characterAction)
        {
            case "Heal":
                Debug.Log("Heal up!");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up!");
                break;
        }
    }
}
