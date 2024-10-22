using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{
    //Jump
    public Transform groundCheckOrigin;
    public float checkRadius;
    public LayerMask groundMask;
    public bool isGrounded = true;

    public float speed = 40f;

    private Rigidbody rigidbdy;
    private float horizontal;
    private float vertical;

    // Awake is called before Start.
    void Awake()
    {
        //Grab the rigidbody component of the player.
        rigidbdy = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //Vector3 velocity = rigidbody.velocity;
        Vector3 velocity = Vector3.zero;

        velocity.x += horizontal;
        velocity.z += vertical;
        rigidbdy.velocity = velocity * speed * Time.fixedDeltaTime;
        //rigidbdy.AddRelativeForce(Vector3.forward + velocity * speed * Time.fixedDeltaTime);

        //Debug.Log("velocity: " + velocity);

        isGrounded = Physics.CheckSphere(groundCheckOrigin.position, checkRadius, groundMask);

        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            //Can jump. Add velocity
            Debug.Log("Can jump");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        }
    }
}