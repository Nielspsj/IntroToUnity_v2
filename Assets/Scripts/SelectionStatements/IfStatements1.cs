using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements1 : MonoBehaviour
{
    //If statement

    public bool hasDungeonKey = true;
    // Start is called before the first frame update
    void Start()
    {
        if(hasDungeonKey)
        {
            Debug.Log("You possess the secret key - ENTER.");
        }
    }    
}
