using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements2 : MonoBehaviour
{
    //If-else statement

    public bool hasDungeonKey = true;
    // Start is called before the first frame update
    void Start()
    {
        if(hasDungeonKey)
        {
            Debug.Log("You possess the secret key - ENTER.");
        }
        else
        {
            Debug.Log("You have not proven yourself worthy, warrior.");
        }
    }
}
