using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pressurePlateScript : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime= 10f;
    public static bool ifPressed { get; set; }
    //Lets us add text to the right script
    [SerializeField]Text countDown;

     void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (ifPressed)
        {  
            //making time
            currentTime -= 1 * Time.deltaTime;
            countDown.text = currentTime.ToString("0");
            //Make sure we dont go into negative numbers
            if (currentTime <= 0)
            {
                playerInfo.Health--;
                ifPressed = false;
                currentTime = 10;

            }
        }
           


    }

    private void OnTriggerEnter2D(Collider2D collision)//player collide with pressurePlate
    {
      
         ifPressed = true;
            gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip, .4f);
    }



}
