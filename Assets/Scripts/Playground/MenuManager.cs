using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuManager : MonoBehaviour
{
    public TMP_Text diceText;
    public GameObject menu;
    private bool isPaused = false;
    private int diceResult = 5;
    // Start is called before the first frame update
    void Awake()
    {
        menu.SetActive(false);
    }

    private void Start()
    {
        diceText.text = diceResult.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        //An If statement that checks for Escape input.
        //Activate the menu object.
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false) 
            {
                menu.SetActive(true);
                isPaused = true;
            }
            else
            {
                menu.SetActive(false);
                isPaused = false;
            }
        }
    }
}
