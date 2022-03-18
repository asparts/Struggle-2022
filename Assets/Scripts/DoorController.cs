using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject door;
    public AudioSource doorFX;
    public bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
 
    }

    public void Interact() {

        if (open == false)
        {
            door.GetComponent<Animator>().Play("Opening");
            Debug.Log("open");
            open = true;
        }
        else
        {
            door.GetComponent<Animator>().Play("Closing");
            Debug.Log("close");
            open = false;
        }

    }
}
