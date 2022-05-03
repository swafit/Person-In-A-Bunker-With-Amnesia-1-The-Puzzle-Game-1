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

    private bool isInventory = true;


    [SerializeField]
    Canvas inventoryCanvas;


    // Start is called before the first frame update
    void Start()
    {
        item1 = true;
    
        inventoryCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        showInventory();
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
                        //Debug.Log(go.name);
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
        if (item2 && cableGenScript.inTriggerObj == "Player")
        {
            cableGenScript.isCableUsed = true;
            //Debug.Log(cableGenScript.isCableUsed);
            item2 = false;
        }
       
    }

    public void CircuitUse()
    {
        if (item3 && circuitGenScript.inTriggerObj == "Player")
        {
            circuitGenScript.isCircuitUsed = true;
            //Debug.Log(cableGenScript.isCableUsed);
            item3 = false;
        }

    }

    public void WireUse()
    {
        if (item4 && wireGenScript.inTriggerObj == "Player")
        {
            wireGenScript.isWireUsed = true;
            //Debug.Log(cableGenScript.isCableUsed);
            item4 = false;
        }

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

    void showInventory()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventoryCanvas.enabled = isInventory;
            isInventory = !isInventory;
        }
    }


}
