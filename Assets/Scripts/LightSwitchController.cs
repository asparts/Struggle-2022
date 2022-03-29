using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour
{

    [SerializeField] GameObject lamp;
    [SerializeField] GameObject lightSwitch;
    public bool lightSwitchOn = true; //TODO: Should randomize on start maybe..


    //TODO: GlobalStats --> Electricityusage
    public GameObject GlobalElectricity;
    private GlobalElectricity globalElectricityScript;


    void Awake()
    {
        globalElectricityScript = GlobalElectricity.GetComponent<GlobalElectricity>();
    }

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
        // TODO: Play Switch animation
        // Shut light off
        if (lightSwitchOn)
        {
            lamp.SetActive(false);

            lightSwitchOn = false;
            globalElectricityScript.DecreaseConsume(0.06f);
        }
        else if (!lightSwitchOn)
        {
            lamp.SetActive(true);
            lightSwitchOn = true;
            globalElectricityScript.AddConsume(0.06f);
        }


    }
}
