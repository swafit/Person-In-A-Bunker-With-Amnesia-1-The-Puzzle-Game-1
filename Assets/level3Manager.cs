using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class level3Manager : MonoBehaviour
{

    [SerializeField]
    public List<GameObject> simonButtons;
    public static bool sequenceDone = true;

   

    void Start()
    {
      
    }

    void Update()
    {
     
        if (buttonInteractScript.isFailed && sequenceDone)
        {
            sequenceDone = false;
            shuffleList();
            StartCoroutine(blink(simonButtons[0]));
            buttonInteractScript.isFailed = false;
          
        }

        if (buttonInteractScript.currentChoice != simonButtons[buttonInteractScript.current].name && buttonInteractScript.currentChoice != "NoChoice")
        {
            buttonInteractScript.isFailed = true;
            buttonInteractScript.currentChoice = "NoChoice";
            buttonInteractScript.current = 0;
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

}
