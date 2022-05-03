using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wireGenScript : MonoBehaviour
{


    public static bool isWireUsed { get; set; }
    public static string inTriggerObj { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        inTriggerObj = "Player";
        if (collision.tag == "Player")
        {
            Debug.Log(isWireUsed);

            if (isWireUsed)
            {
                level2ManagerScript.checkGenWorking++;
                isWireUsed = false;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Item Added");
            inventoryManager.item4 = true;
            Destroy(this.transform.gameObject);
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
