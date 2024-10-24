using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCharCtrlSimpleMove : MonoBehaviour
{
    public float speed = 2f;
    public float jumpForce = 1f;
    CharacterController controller;
    private Vector3 moveDirection;
    private float gravityValue = -9.81f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded && moveDirection.y < 0)
        {
            moveDirection.y = 0f;
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        Debug.Log("grounded " + controller.isGrounded);
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded == true)
        {
            Debug.Log("jumped");
            moveDirection.y += Mathf.Sqrt(jumpForce * -3.0f * gravityValue);
        }

        //Movement();
        //Jump();

        moveDirection.y += gravityValue * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


    }
    
    private void Movement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && controller.isGrounded == true)
        {
            moveDirection.y += Mathf.Sqrt(jumpForce * -3.0f * gravityValue);
        }
    }
}
