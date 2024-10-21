using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 speed;

    private Rigidbody rigidbdy;

    // Start is called before the first frame update
    void Start()
    {
        rigidbdy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbdy.velocity = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        //speed *= -1;
        speed = -speed;
    }
}
