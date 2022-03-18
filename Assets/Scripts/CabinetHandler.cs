using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetHandler : MonoBehaviour
{

    public GameObject cabinet;
    public AudioSource cabinetFX;
    public bool open = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {

        if (open == false)
        {
            cabinet.GetComponent<Animator>().Play("Opening");
            Debug.Log("open");
            open = true;
        }
        else
        {
            Debug.Log("close");
            cabinet.GetComponent<Animator>().Play("Closing");
            
            open = false;
        }

    }
}
