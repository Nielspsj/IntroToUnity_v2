using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UnityCharacterController : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController characterController;
    private float gravity = 5.5f;
    private Vector3 bodyVelocity;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gravity
        if (characterController.isGrounded == true)
        {
            bodyVelocity.y = 0;
        }
        else
        {
            bodyVelocity.y = -gravity * Time.deltaTime;
        }

        Vector3 movementInputs = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(movementInputs * speed * Time.deltaTime);
        characterController.Move(bodyVelocity);
    }
}
