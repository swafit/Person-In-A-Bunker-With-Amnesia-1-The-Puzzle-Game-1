using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addingItemScirpt : MonoBehaviour
{


    [SerializeField] 
    Text addedText;


    void Start()
    {
        
    }

   
    void Update()
    {
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {

           
            addedText.text = "Item Added: " + gameObject.name.ToString();
            this.gameObject.transform.position = new Vector3(-100,-100,100);
            StartCoroutine(disableAddedText());
        }
        
    }

 
    IEnumerator disableAddedText()
    {
       
        yield return new WaitForSeconds(1f);
        addedText.text = "";
        Destroy(this.gameObject);
    }

}
