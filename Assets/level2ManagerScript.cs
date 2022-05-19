using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2ManagerScript : MonoBehaviour
{

    public static int checkGenWorking { get; set; }
    
   



    // Start is called before the first frame update
    void Start()
    {
        
        playerInfo.LevelNum = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(checkGenWorking);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (checkGenWorking >= 3)
        {
            SceneManager.LoadScene("FinalLevel");
            saveScript.isLoaded = true;
        }
        else
        {
            playerInfo.Health--;
        }
    }

}
