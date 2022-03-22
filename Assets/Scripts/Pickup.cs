using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{

    [SerializeField] RawImage inventorySprite;


    /**
     If item is pickable, check if there's space in inventory, 
        disable 3d object and add corresponding 2d item to inventory
         
         --> Probably have to do dropping off with raycast 
         */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
