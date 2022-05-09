using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonInteractScript : MonoBehaviour
{

    public static bool isFailed { get; set; }
    public static int current { get; set; }
   


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

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (level3Manager.sequenceDone)
        {   
            currentChoice = this.gameObject.tag;
            current++;
           
        }   
               
    }



    

}
