using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPad : MonoBehaviour
{
    //Collide with this collider and be sent upwards
    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.velocity = Vector3.up * 10f;
    }
}
