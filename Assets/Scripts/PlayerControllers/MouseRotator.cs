using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    public float sensitivity = 100f;

    private float x;
    //private Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        RotateWithMouseInput();
    }

    //Grab mouse input and rotate the transform this script is on.
    private void RotateWithMouseInput()
    {
        x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * x);

        //rotate = new Vector3(0, x, 0);
        //transform.eulerAngles += rotate;
    }
}
