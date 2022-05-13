using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{

    [SerializeField]
    Toggle toggleSound;

    [SerializeField]
    Toggle toggleScreen;

    [SerializeField]
    List<GameObject> boxes;

    // Start is called before the first frame update
    void Start()
    {
        hideAll();
    }

    // Update is called once per frame
    void Update()
    {
        toggleStuff();
    }

    public void startGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void loadSave()
    {
        //Save script needed
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void showOptions()
    {
        boxes.Where(x => x.name == "Options").First().SetActive(true);
    }

    public void toggleStuff()
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
}
