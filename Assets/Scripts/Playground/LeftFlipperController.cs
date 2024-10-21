﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipperController : MonoBehaviour {

    public float restPosition_F = 0f;
    public float pressedPosition_F = 45f;
    public float hitStrength_F = 10000f;
    public float flipperDamper_F = 150f;

    private HingeJoint hinge_HJ;


	// Use this for initialization
	void Start ()
    {
        hinge_HJ = GetComponent<HingeJoint>();
        GetComponent<HingeJoint>().useSpring = true;		
	}
	
	// Update is called once per frame
	void Update ()
    {
        JointUpdate();
    }

    private void JointUpdate ()
    {
        JointSpring spring_JS = new JointSpring();
        spring_JS.spring = hitStrength_F;
        spring_JS.damper = flipperDamper_F;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("hitting left arrow");
            spring_JS.targetPosition = pressedPosition_F;
        }
        else
        {
            spring_JS.targetPosition = restPosition_F;
        }

        hinge_HJ.spring = spring_JS;
        hinge_HJ.useLimits = true;
    }
}
