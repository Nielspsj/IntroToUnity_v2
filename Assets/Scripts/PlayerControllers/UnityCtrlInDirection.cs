using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UnityCtrlInDirection : MonoBehaviour
{
    //Jump
    public Transform groundCheckOrigin;
    public float checkRadius;
    public LayerMask groundMask;
    public bool isGrounded = false;

    public float speed = 5f;

    private CharacterController characterController;
    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        characterController.detectCollisions = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    //Grab input and move relative to rotation of transform.
    private void MoveCharacter()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 movementInputs = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(movementInputs * speed * Time.deltaTime);
    }
}
