using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowCharts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomNr;
        randomNr = Random.Range(0, 2);
        if(randomNr == 0)
        {
            print("You are safe");
        }
        else  
        {
            Debug.Log("BOOOOM!");
        }
    }
}
