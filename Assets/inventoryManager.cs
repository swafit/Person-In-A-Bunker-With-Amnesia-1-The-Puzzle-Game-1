using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class inventoryManager : MonoBehaviour
{


    public bool[] items = new bool[7];
    public static bool item1 { get; set; }
    public static bool item2 { get; set; }
    public static bool item3 { get; set; }
    public static bool item4 { get; set; }
    public static bool item5 { get; set; }
    public static bool item6 { get; set; }
    public static bool item7 { get; set; }

   

    // Start is called before the first frame update
    void Start()
    {
        item1 = true;
        item4 = true;
    }

    // Update is called once per frame
    void Update()
    {
        

        updateList();
        updateColors();
        playerInfo.Inventory = items.ToList();
    }
    
    void updateList()
    {
        for(int i = 0; i != 7; i++)
        {
            switch (i)
            {
                case 0: items[0] = item1;
                    continue;
                case 1: items[1] = item2;
                    continue;
                case 2: items[2] = item3;
                    continue;
                case 3: items[3] = item4;
                    continue;
                case 4: items[4] = item5;
                    continue;
                case 5: items[5] = item6;
                    continue;
                case 6: items[6] = item7;
                    continue;
            }
        }
        
    }

    void updateColors()
    {
     
            for(int i = 0; i < items.Length; i++)
            {

                int y = i + 1;
            GameObject.FindGameObjectsWithTag("Item" + y.ToString()).First().GetComponent<Text>().color = Color.gray;

                if (items[i])
                    {
                    
                        GameObject go = GameObject.FindGameObjectsWithTag("Item" + y.ToString()).First();
                        Debug.Log(go.name);
                        go.GetComponent<Text>().color = Color.cyan;

                    }
            
            }
    }
    
    public void HealthShot()
    {
        item1 = !item1;
    }
    
    public void CableUse()
    {
        item2 = !item2;
    }

    public void CircuitUse()
    {
        item3 = !item3;
    }

    public void WireUse()
    {
        item4 = !item4;
    }
    
    public void NoteUse1()
    {
        item5 = !item5;
    }
    
    public void NoteUse2()
    {
        item6 = !item6;
    }
    
    public void NoteUse3()
    {
        item7 = !item7;
    }


}
