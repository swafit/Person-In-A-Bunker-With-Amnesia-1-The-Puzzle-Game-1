using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    [SerializeField] Canvas optionCanvas, mainmenuCanvas;
    private void Start()
    {
        optionCanvas.GetComponent<Canvas>().enabled = false;
        mainmenuCanvas.GetComponent<Canvas>().enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainmenuCanvas.GetComponent<Canvas>().enabled = true;
            optionCanvas.GetComponent<Canvas>().enabled = false;
        }
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
