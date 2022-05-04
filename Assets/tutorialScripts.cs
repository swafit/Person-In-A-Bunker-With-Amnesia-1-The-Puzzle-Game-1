using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tutorialScripts : MonoBehaviour
{


    [SerializeField]
    Text HealShotText, useInventoryText, moveText;


    private bool healthMessageShown = true, inventoryMessageShown = false, moveTextShown = true;


    // Start is called before the first frame update
    void Start()
    {
        disableText(HealShotText);
        disableText(useInventoryText);
        enableText(moveText);
   
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") > 0 && moveTextShown)
        {
            StartCoroutine(disableText(moveText, 3));
            moveTextShown = false;
        }

        if (pickUpHealthScript.healthPickedUp == "Player" && healthMessageShown)
        {
            enableText(HealShotText);
            StartCoroutine(disableText(HealShotText, 10));
            healthMessageShown = false;
            inventoryMessageShown = true;
        }

        if (inventoryMessageShown)
        {
            enableText(useInventoryText);
        }


    }


    void enableText(Text text)
    {
        text.enabled = true;
    }

    IEnumerator disableText(Text text)
    {
        text.enabled = false;
         return null; 
    }


    IEnumerator disableText(Text text, int timer)
    {
        yield return new WaitForSeconds(timer);
        text.enabled = false;
        
    }

   



}
