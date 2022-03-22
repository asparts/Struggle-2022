using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GlobalStats : MonoBehaviour
{
    private float warmth = 0;
    private float thirst = 5;
    private float hunger = 10;
    private float anxiety = 30;
    private float depression = 30;
    private float dirtiness = 20;
    private float health = 100;
    private float fatigue = 20;
    private float money = 1000;
    //[Space]
    //[SerializeField] TIME

    public Image healthBar;
    public Image thirstBar;
    public Image hungerBar;
    public Image anxietyBar;
    public Image depressionBar;
    public Image dirtinessBar;
    public Image fatigueBar;
    public Text moneyText;




    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Money: " + money.ToString();
        UpdateStats();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStats();

        if (health <= 0)
        {
            //GAME OVER
        }
        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            TakeDamage(10);
        }
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            Healing(10);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 100;
    }
    public void Healing(float healPoints)
    {
        health += healPoints;
        health = Mathf.Clamp(health, 0 , 100);
        healthBar.fillAmount = health / 100;
    }

    private void UpdateStats()
    {
        thirstBar.fillAmount = thirst / 100;
        hungerBar.fillAmount = hunger / 100;
        anxietyBar.fillAmount = anxiety / 100;
        depressionBar.fillAmount = depression / 100;
        dirtinessBar.fillAmount = dirtiness / 100;
        fatigueBar.fillAmount = fatigue / 100;

        if(thirst >= 99)
        {
            TakeDamage(1);
        }
        if (hunger >= 99)
        {
            TakeDamage(1);
        }
        if (anxiety >= 99)
        {
            TakeDamage(1);
        }
        if (depression >= 99)
        {
            TakeDamage(1);
        }
        if (dirtiness >= 99)
        {
            TakeDamage(1);
        }
        if (fatigue >= 99)
        {
            TakeDamage(1);
        }

    }


    //GETTERS AND SETTERS,
    // these should be atleast called from Clock I think in order to maintain them..

    public void AddWarmth(float amount)
    {
        this.warmth += amount;
    }
    public void DecreaseWarmth(float amount)
    {
        this.warmth -= amount;
    }
    public void AddThirst(float amount)
    {
        this.thirst += amount;
    }
    public void DecreaseThirst(float amount)
    {
        this.thirst -= amount;
    }
    public void AddHunger(float amount)
    {
        this.hunger += amount;
    }
    public void DecreaseHunger(float amount)
    {
        this.hunger -= amount;
    }
    public void AddAnxiety(float amount)
    {
        this.anxiety += amount;
    }
    public void DecreaseAnxiety(float amount)
    {
        this.anxiety -= amount;
    }
    public void AddDepression(float amount)
    {
        this.depression += amount;
    }
    public void DecreaseDepression(float amount)
    {
        this.depression -= amount;
    }
    public void AddDirtiness(float amount)
    {
        this.dirtiness += amount;
    }
    public void DecreaseDirtiness(float amount)
    {
        this.dirtiness -= amount;
    }
    public void AddFatigue(float amount)
    {
        this.fatigue += amount;
    }
    public void DecreaseFatigue(float amount)
    {
        this.fatigue -= amount;
    }


    public void AddMoney (float amount)
    {
        this.money += amount;
    }
    public void DecreaseMoney(float amount)
    {
        this.money -= amount;
    }

}
