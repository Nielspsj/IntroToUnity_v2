using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirection : MonoBehaviour
{
    public float speed = 40f;

    private Rigidbody rigidbdy;
    private Vector3 directionInputs;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbdy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        directionInputs = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        MoveCharacter (directionInputs);
    }

    private void MoveCharacter(Vector3 direction)
    {
        direction = rigidbdy.rotation * direction;

        rigidbdy.MovePosition(rigidbdy.position + direction * speed * Time.fixedDeltaTime);
    }
}
