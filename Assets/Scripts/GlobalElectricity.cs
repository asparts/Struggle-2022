using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalElectricity : MonoBehaviour
{
    //TODO: DO SAME KINDA SCRIPT FOR WATER ALSO

    float electricityPrice = 0.07f; // c/kWh
    float currentConsumePerSecond = 0.8f; // kWh should decide baseconsume what comes from fridge etc
    float amountConsumed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddConsume(float amount)
    {
        this.currentConsumePerSecond += amount;
    }
    public void DecreaseConsume(float amount)
    {
        this.currentConsumePerSecond -= amount;
    }
    //THIS IS CALLED FROM TIME SYSTEM
    public void IncreaseAmountConsumed()
    {
        amountConsumed += currentConsumePerSecond;
    }
    public void WipeAmountConsumed()
    {
        amountConsumed = 0;
    }
    public void SetBill()
    {

    }
}
