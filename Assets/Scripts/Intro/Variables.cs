using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Assignment 1: Predict what the code does.
    //Assignment 2: Add comments to explain what the code does.
    //Assignment 3: Change all variable names into something descriptive and meaningful.

    public string someString = "Hello World!";
    public int someWholeNumber = 45;
    private float myFloat;

    // Start is called before the first frame update
    private void Start()
    {
        myFloat = 1.4f;
        someWholeNumber = 4 + 5;

        //bool onOff = false;

        print(myFloat);
        print(someWholeNumber);
    }
}
