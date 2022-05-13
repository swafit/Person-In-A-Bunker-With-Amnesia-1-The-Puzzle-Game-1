using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonInteractScript : MonoBehaviour
{

    public static bool isFailed { get; set; }
    public static int current { get; set; }
    public static bool isPressed { get; set; }


    [HideInInspector]
    public static string currentChoice, lastChoice;

    // Start is called before the first frame update
    void Start()
    {
        isFailed = true;
        current = 0;
        currentChoice = "NoChoice";
        lastChoice = currentChoice;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Used to change the current player choice
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (level3Manager.sequenceDone)
        {

            currentChoice = this.gameObject.tag;
            
        }   
               
    }

    //Used to increment current player choice number
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (current < 4 && !isFailed)
        {
            current++;
            lastChoice = currentChoice;
            Debug.Log(current);
        }
        
   
    }


}
