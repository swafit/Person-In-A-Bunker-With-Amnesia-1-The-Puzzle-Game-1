using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cableGenScript : MonoBehaviour
{

    public static bool isCableUsed { get; set; }
    public static string inTriggerObj { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        inTriggerObj = "Player";
        if (collision.tag == "Player")
        {
            //Debug.Log(isCableUsed);

            if (isCableUsed)
            {
                level2ManagerScript.checkGenWorking++;
                isCableUsed = false;
            }

            

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
           
            inventoryManager.item2 = true;
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        inTriggerObj = "";
    }

}
