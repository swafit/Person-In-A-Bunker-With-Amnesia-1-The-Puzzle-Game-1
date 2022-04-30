using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class optionsMenuScript : MonoBehaviour
{

    [SerializeField]
    Canvas canvas;

    [SerializeField]
    List<GameObject> boxes;
    

    [SerializeField]
    Toggle toggleSound;

    [SerializeField]
    Toggle toggleScreen;



    private bool isMenuEnabled = true;


    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showMenu();
        }

        if (!isMenuEnabled)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }


        toggleSoundStuff();

        //Debug.Log(Time.timeScale);

    }

    public void showMenu()
    {
        canvas.enabled = isMenuEnabled;
        isMenuEnabled = !isMenuEnabled;
        hideAll();
    }

    public void showOptions()
    {

        hideAll();
        boxes.Where(x => x.name == "Options").First().SetActive(true);

  
    }

    public void showSave()
    {

        hideAll();
        boxes.Where(x => x.name == "ConfirmSave").First().SetActive(true);

    }

    public void showQuit()
    {

        hideAll();
        boxes.Where(x => x.name == "QuitOptions").First().SetActive(true);

    }

    public void toggleSoundStuff()
    {
        //Sound toggle
        if (!toggleSound.isOn)
        {
            toggleSound.GetComponent<Image>().color = new Color(55, 23, 10);// Hex code is 552310
        }
        else
        {
            toggleSound.GetComponent<Image>().color = Color.red;
        }


        //Screen Toggle
        if (!toggleScreen.isOn)
        {
            toggleScreen.GetComponent<Image>().color = new Color(55, 23, 10);// Hex code is 552310
            Screen.fullScreen = true;
          
        }
        else
        {
            toggleScreen.GetComponent<Image>().color = Color.red;
            Screen.fullScreen = false;
            Debug.Log(Screen.fullScreen);
        }


    }

    public void hideAll()
    {
        foreach (var w in boxes)
        {
            w.SetActive(false);
        }
    }


    public void QuitMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
   

}
