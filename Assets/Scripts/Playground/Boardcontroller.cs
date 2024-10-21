using UnityEngine;
using System.Collections;

public class Boardcontroller : MonoBehaviour {
	public float boxDepth = 1.0f;
	public float boxWidth = 1.0f;
	public float boxHeight = 1.0f;
	public float boxThickness = 1f;
	public Vector3 boxPosition = new Vector3(0.0f, 0.0f, 0.0f);
    public int rowMaxCount = 1;
    public int columnMaxCount = 1;
    public Color pegColor = new Color(0,0,0,0);

    // Use this for initialization
    void Start () 
	{
        CreateBoard();
        CreatePins();
    }
	
    //Create the board with floor and walls
	private void CreateBoard()
	{
        //Create an empty game object to hold the box
        GameObject box = new GameObject();
        box.name = "Box";
        box.transform.parent = transform;

        //Floor
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.transform.position = boxPosition;
        floor.transform.localScale = new Vector3(boxWidth, boxThickness, boxDepth);
        floor.name = "Floor";
        floor.transform.parent = box.transform;

        //Right Wall
        GameObject rightWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rightWall.transform.position = boxPosition + new Vector3(boxWidth / 2, boxHeight / 2, 0);
        rightWall.transform.localScale = new Vector3(boxThickness, boxHeight, boxDepth);
        rightWall.name = "Right wall";
        rightWall.transform.parent = box.transform;

        //Left Wall
        GameObject leftWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        leftWall.transform.position = boxPosition + new Vector3(-boxWidth / 2, boxHeight / 2, 0);
        leftWall.transform.localScale = new Vector3(boxThickness, boxHeight, boxDepth);
        leftWall.name = "Left wall";
        leftWall.transform.parent = box.transform;

        //Far wall
        GameObject farWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        farWall.transform.position = boxPosition + new Vector3(0, boxHeight / 2, boxDepth / 2);
        farWall.transform.localScale = new Vector3(boxWidth, boxHeight, boxThickness);
        farWall.name = "Far wall";
        farWall.transform.parent = box.transform;

        //Near wall
        GameObject nearWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        nearWall.transform.position = boxPosition + new Vector3(0, boxHeight / 2, -boxDepth / 2);
        nearWall.transform.localScale = new Vector3(boxWidth, boxHeight, boxThickness);
        nearWall.name = "Near wall";
        nearWall.transform.parent = box.transform;
    }

    //place 81 cylinders on the floor
    private void CreatePins()
	{
        GameObject pegs = new GameObject();
        pegs.name = "Pegs";
        pegs.transform.parent = transform;

        int disp = 0;

        for (int row = 0; row < rowMaxCount; row++)
        {
            for (int col = 0; col < columnMaxCount; col++)
            {
                if (row % 2 == 0)
                {
                    disp = 0;
                }

                else
                {
                    disp = 1;
                }
                GameObject peg = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                peg.transform.position = new Vector3(2 * (-4 + col) + disp, 0.45f, -4 + 2 * (-3 + row));
                peg.transform.localScale = new Vector3(0.5f, 0.4f, 0.5f);
                peg.transform.GetComponent<Renderer>().material.color = pegColor;
                peg.name = "Peg(" + col + ", " + row + ")";
                peg.transform.parent = pegs.transform;                
            }
        }
    }
}
