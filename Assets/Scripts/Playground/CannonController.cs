﻿using UnityEngine;
using System.Collections;
using System.Xml.Serialization;

public class CannonController : MonoBehaviour {
	
	public float deltaAngle = 1.0f;
	private float elevationAngle = 0.0f;  //up and down
    private float turnAngle = 0.0f; //right and left
    private float speed = 2.0f;
	public float muzzleVelocity;
	public GameObject grenadePrefab; 
	
	// Update is called once per frame
	void Update () 
	{
        MoveCannon();
    }

    //the keys that we use to control and shoot
    void MoveCannon()
	{
        if (Input.GetKey(KeyCode.W))
        {
            elevationAngle -= deltaAngle;
        }
        if (Input.GetKey(KeyCode.S))
        {
            elevationAngle += deltaAngle;
        }
        if (Input.GetKey(KeyCode.A))
        {
            turnAngle -= deltaAngle;
        }
        if (Input.GetKey(KeyCode.D))
        {
            turnAngle += deltaAngle;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }

        //a special vector data type in Unity to deal with rotation in 3d space
        Quaternion target = Quaternion.Euler(elevationAngle, turnAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
    }
	
	void FireCannon() 
    {		
		GameObject muzzle = GameObject.Find("Muzzle");
		GameObject grenade = (GameObject)Instantiate(grenadePrefab, muzzle.transform.position, muzzle.transform.rotation);
		grenade.transform.GetComponent<Rigidbody>().velocity = muzzle.transform.forward * muzzleVelocity;
	}
}