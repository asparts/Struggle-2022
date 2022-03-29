using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour
{

    [SerializeField] GameObject Bed;
    [SerializeField] GameObject fade;

    //FOR CALLS TO GLOBALSTATS
    public GameObject GlobalStatsBars;
    private GlobalStats globalStatsScript;

    void Awake()
    {
        globalStatsScript = GlobalStatsBars.GetComponent<GlobalStats>();
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
        fade.GetComponentInParent<Canvas>().enabled = true;
        fade.GetComponent<Animator>().Play("FadeInAnim");
        fade.GetComponent<Animator>().Play("FadeOut");
        fade.GetComponentInParent<Canvas>().enabled = false;
        globalStatsScript.DecreaseFatigue(100);

    }
}
