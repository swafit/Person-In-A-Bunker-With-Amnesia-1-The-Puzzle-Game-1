using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonInteractScript : MonoBehaviour
{

    public static bool isFailed { get; set; }
    public static int current { get; set; }
   


    [HideInInspector]
    public static string currentChoice, lastChoice;

    void Start()
    {
        isFailed = true;
        current = 0;
        currentChoice = "NoChoice";
        lastChoice = currentChoice;
    }

    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (level3Manager.sequenceDone)
        {   
            currentChoice = this.gameObject.tag;
            current++;
           
        }   
               
    }



    

}
