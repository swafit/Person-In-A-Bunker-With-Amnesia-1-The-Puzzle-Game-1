using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addingItemScirpt : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;

    [SerializeField] 
    Text addedText;


    void Start()
    {
        currentTime = startingTime;
    }

   
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime == 0f)
        {
            addedText.text = "";
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            startingTime = 3f;
            addedText.text = "Item Added: " + gameObject.name.ToString();
        }
    }

 

}
