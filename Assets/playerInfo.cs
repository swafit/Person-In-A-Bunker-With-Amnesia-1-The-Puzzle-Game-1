using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInfo : MonoBehaviour
{

    public static int LevelNum { get; set; }
    public static List<bool> Inventory { get; set; }

    //Access the health here and do --1 each the time the player is hurt
    public static int Health { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Health = 2;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
