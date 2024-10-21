using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Transform groundCheckOrigin;
    public float checkRadius;
    public LayerMask groundMask;

    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheckOrigin.position, checkRadius, groundMask);

        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            //Can jump. Add velocity
            Debug.Log("Can jump");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        }
    }
}
