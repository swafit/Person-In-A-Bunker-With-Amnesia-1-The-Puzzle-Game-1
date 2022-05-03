using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuitGenScript : MonoBehaviour
{


    public static bool isCircuitUsed { get; set; }
    public static string inTriggerObj { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        inTriggerObj = "Player";
        if (collision.tag == "Player")
        {
            Debug.Log(isCircuitUsed);

            if (isCircuitUsed)
            {
                level2ManagerScript.checkGenWorking++;
                isCircuitUsed = false;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Item Added");
            inventoryManager.item3 = true;
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