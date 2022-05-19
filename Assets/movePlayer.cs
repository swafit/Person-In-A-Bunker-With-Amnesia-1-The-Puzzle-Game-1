using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    AudioSource audio;
    bool isWalking = false;
    

    // Start is called before the first frame update
    void Start()
    {
        audio = this.gameObject.GetComponent<AudioSource>();
        audio.loop = true;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 2, Input.GetAxis("Vertical") * Time.deltaTime * 2, 0);



        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            isWalking = true;  
        }
        else
        {
            isWalking = false;
        }
        playerSound.runningSoundMethod(audio, isWalking);



    }


   





    

}
