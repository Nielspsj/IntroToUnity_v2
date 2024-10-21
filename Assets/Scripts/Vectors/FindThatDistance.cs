using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindThatDistance : MonoBehaviour
{
    private GameObject targetObject;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        CalculateDistance();
    }

    // Update is called once per frame
    public void CalculateDistance()
    {
        targetObject = GameObject.Find("Cuby");
        //targetObject = GameObject.FindGameObjectWithTag("Target");
        distance = Vector3.Distance(transform.position, targetObject.transform.position);
        Debug.Log("The distance is: " + distance);
    }
}
