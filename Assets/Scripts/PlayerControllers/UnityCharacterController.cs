using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UnityCharacterController : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementInputs = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(movementInputs * speed * Time.deltaTime);
    }
}
