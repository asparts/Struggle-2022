using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ComputerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            // -- > Fade out
            // --> Set UI Disabled
            // -- Fade in
        }
    }

    public void Interact()
    {
        // --> Fade in
        // SET UI ENABLED
        // --> Fade out


    }

    //TODO: Shit to affect on GLOBAL STATS


}
