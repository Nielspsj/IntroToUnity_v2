using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1 : MonoBehaviour
{
    //Switch statement

    // Start is called before the first frame update
    void Start()
    {
        string aIState = "Patrolling";

        switch(aIState)
        {                      
            case "Alert":
                Debug.Log("It noticed me!");
                break;
            case "Chase":
                Debug.Log("It's coming for me!");
                break;
            default:
                Debug.Log("AI is patrolling around.");
                break;
        }
    }
}
