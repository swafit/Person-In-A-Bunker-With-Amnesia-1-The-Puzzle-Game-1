using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;



public class level3Manager : MonoBehaviour
{

    [SerializeField]
    public List<GameObject> simonButtons;
    public static bool sequenceDone = true;
    public static bool isPassed = false;
   

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     
        //Starts a new iteration if the player failed
        if (buttonInteractScript.isFailed && sequenceDone)
        {
            sequenceDone = false;
            shuffleList();
            StartCoroutine(blink(simonButtons[0]));
            buttonInteractScript.isFailed = false;
          
        }

        //If the current choice is not -1 than check if the player has failed the simon says iteration or not
        if (buttonInteractScript.current > -1 && buttonInteractScript.current < 4) {
            if (buttonInteractScript.currentChoice != simonButtons[buttonInteractScript.current].name && buttonInteractScript.currentChoice != buttonInteractScript.lastChoice && buttonInteractScript.currentChoice != "NoChoice")
            {
                buttonInteractScript.isFailed = true;
                buttonInteractScript.currentChoice = "NoChoice";

                //Set to negative 1 since the "current" integer will increase by 1 after player leaves the trigger area therefore -1 -> 0, instead of 0 -> 1
                buttonInteractScript.current = -1;
            }

        }

        if (buttonInteractScript.current == 4)
        {
            isPassed = true;
        }


    }

    void shuffleList() 
    {
        simonButtons = simonButtons.OrderBy(x => Random.value).ToList();

    }



    IEnumerator blink(GameObject go)
    {
      
        setColor(go);
        yield return new WaitForSeconds(1);
        go.GetComponent<SpriteRenderer>().color = Color.white;
        StartCoroutine(blink2(simonButtons[1]));
        
    }

    IEnumerator blink2(GameObject go)
    {

        setColor(go);
        yield return new WaitForSeconds(1);
        go.GetComponent<SpriteRenderer>().color = Color.white;
        StartCoroutine(blink3(simonButtons[2]));
    }

    IEnumerator blink3(GameObject go)
    {

        setColor(go);
        yield return new WaitForSeconds(1);
        go.GetComponent<SpriteRenderer>().color = Color.white;
        StartCoroutine(blink4(simonButtons[3]));
    }

    IEnumerator blink4(GameObject go)
    {

        setColor(go);
        yield return new WaitForSeconds(1);
        go.GetComponent<SpriteRenderer>().color = Color.white;
        sequenceDone = true;
        Debug.Log(sequenceDone);

    }



    void setColor(GameObject go)
    {
        switch (go.name)
        {

            case "SimonButton1": go.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case "SimonButton2": go.GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
            case "SimonButton3": go.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case "SimonButton4": go.GetComponent<SpriteRenderer>().color = Color.green;
                break;


        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isPassed)
        {
            SceneManager.LoadScene("EndGame");
        }
    }

}
