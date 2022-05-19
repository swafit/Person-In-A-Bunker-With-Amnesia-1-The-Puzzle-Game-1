using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class playerInfo : MonoBehaviour
{

    public static int LevelNum { get; set; }
    public static List<bool> Inventory { get; set; }
    public static bool IsDamaged { get; set; }

    //Access the health here and do --1 each the time the player is hurt
    public static int Health { get; set; }

    int lastHealth;


    // Start is called before the first frame update
    void Start()
    {
        Health = 2;
        lastHealth = Health;
    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Inventory[0]);
        if (lastHealth > Health)
        {
            IsDamaged = true;
        }

      

        lastHealth = Health;

        if (Health == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
[Serializable]
public class saveInfo{

    public List<bool> inv;
    public int lev;
    public int heal;
    public bool mute;
    public bool full;
    public float vol;

}
