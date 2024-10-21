using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffect : MonoBehaviour
{    
    //Called when this object with a collider/rigidbody has begun touching another collider/rigidbody
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            GetComponent<Renderer>().material.color = Color.red;
            collision.transform.localScale += Vector3.one * 0.6f;           
        }
    }

    //Called when this object with a collider/rigidbody has begun touching another collider/rigidbody
    //One of the colliders is a trigger and has a rigidbody
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Ball")
        {
            Destroy(other.gameObject);
        }
    }
    
}
