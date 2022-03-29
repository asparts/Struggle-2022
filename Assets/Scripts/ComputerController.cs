using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ComputerController : MonoBehaviour
{

    [SerializeField] private GameObject computer;
    [SerializeField] private GameObject fade;
    [SerializeField] private GameObject computerUI;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject studyButton;
    [SerializeField] GameObject payBillsButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame && computerUI.GetComponent<Canvas>().enabled == true)
        {
            //TODO: FIX THE FADE ANIMATIONS
            fade.GetComponent<Animator>().Play("FadeOut");
            computerUI.GetComponent<Canvas>().enabled = false;
            fade.GetComponent<Animator>().Play("FadeInAnim");
            
            // -- > Fade out
            // --> Set UI Disabled
            // -- Fade in
        }
    }

    public void Interact()
    {

        fade.GetComponentInParent<Canvas>().enabled = true;
        fade.GetComponent<Animator>().Play("FadeInAnim");
        computerUI.GetComponent<Canvas>().enabled = true;
        fade.GetComponent<Animator>().Play("FadeOut");
        fade.GetComponentInParent<Canvas>().enabled = false;
        



    }

    //TODO: Shit to affect on GLOBAL STATS


}
