using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PhysicsTests requires the gameobject to have a RigidBody component attaced to it.
//If not already attached it will add a new RigidBody component.

[RequireComponent(typeof(Rigidbody))]
public class PhysicsTests : MonoBehaviour
{
    public Rigidbody myRigidBody;

    public float massAmount;
    public bool canUseGravity = true;
    public Vector3 velocity_v3 = Vector3.zero;    
    public float forceAmount = 0;

    //Values from 0 to 1. MovePosition only works if isKinematic is true.
    public Vector3 movePosition_v3 = new Vector3(0, 0, 0);
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.mass = massAmount;
        myRigidBody.useGravity = canUseGravity;
        myRigidBody.velocity = velocity_v3;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        myRigidBody.AddForce(transform.up * forceAmount);

        //Only works if isKinematic is true.
        //Apply the movement vector to the current position, which is.
        //multiplied by deltaTime and speed for a smooth MovePosition.
        myRigidBody.MovePosition(transform.position + movePosition_v3 * speed * Time.deltaTime);  
    }
}
