using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpHealthScript : MonoBehaviour
{
    public static string healthPickedUp { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        healthPickedUp = "Player";
        inventoryManager.item1 = true;
        playerInfo.Health++;
        Debug.Log(playerInfo.Health);
        Destroy(this.gameObject);
    }

    private void FixedUpdate()
    { 
        healthPickedUp = "";

    }

}
