using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCube : MonoBehaviour
{
    public float upwardsy = 0.02f;
    private Vector3 Cubeposition;

    // Start is called before the first frame update
    void Start()
    {
        //cubePosition = GetComponent<Transform>().position;
        Cubeposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movecube();
    }

    void movecube()
    {
        Cubeposition.y += upwardsy;
        transform.position = Cubeposition;
    }
}
