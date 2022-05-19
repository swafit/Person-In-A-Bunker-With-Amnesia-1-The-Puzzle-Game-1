using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSound : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerInfo.IsDamaged && audioSource.clip.name == "Ruffle")
        {
            audioSource.PlayOneShot(audioSource.clip, .2f);
            playerInfo.IsDamaged = false;
        }
    }

    public static void runningSoundMethod(AudioSource audio, bool isWalking)
    {

        if (isWalking)
        {
            audio.UnPause();
        }
        else
        {
            audio.Pause();
        }
    }

}
