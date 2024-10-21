using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    private Rigidbody rigidbdy;
    public float playerForce = 4f;

    // Awake is called before Start.
    void Awake()
    {
        //Grab the rigidbody component of the player.
        rigidbdy = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called 50 times per second.
    void FixedUpdate()
    {
        //Add force left and right. Adjust with playerForce.
        rigidbdy.AddForce(Vector3.right * playerForce * Input.GetAxis("Horizontal"));
    }
}
