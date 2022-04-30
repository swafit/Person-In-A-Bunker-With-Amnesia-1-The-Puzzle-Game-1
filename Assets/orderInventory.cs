using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class orderInventory : MonoBehaviour
{
    public Image[] imgs;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        Sprite img = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Image>().sprite;
        Debug.Log(img.name);
        GameObject go = GameObject.FindGameObjectWithTag("Item1");
        Debug.Log(go.name);
        //Debug.Log(inventoryManager.inventory.ElementAt(0));
        go.GetComponentInChildren<Image>().sprite = img;
    }

}
