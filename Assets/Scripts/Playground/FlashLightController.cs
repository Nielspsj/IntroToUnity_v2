using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour
{
    public Transform flashlight;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementInputs = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (movementInputs != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementInputs, Vector3.up);
            flashlight.rotation = Quaternion.RotateTowards(flashlight.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
