using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GlobalBills : MonoBehaviour
{

    [SerializeField] Text rentText;
    [SerializeField] Text electricityText;
    [SerializeField] Text waterText;
    [SerializeField] Text phoneText;
    [SerializeField] Text internetText;
    [SerializeField] Text streamingServicesText;
    [SerializeField] Text debtText;
    [SerializeField] Text debt2Text;
    [SerializeField] Text creditCardText;
    [SerializeField] Text randomizableText;
    [SerializeField] Text totalText;


    [SerializeField] Sprite checkedImage;
    [SerializeField] Sprite unCheckedImage;
    [SerializeField] Button rentButton;
    [SerializeField] Button electricityButton;
    [SerializeField] Button waterButton;
    [SerializeField] Button phoneButton;
    [SerializeField] Button internetButton;
    [SerializeField] Button streamingButton;
    [SerializeField] Button debtButton;
    [SerializeField] Button debt2Button;
    [SerializeField] Button creditCardButton;



    //TODO: Duedates
    private float rent = 700;
    private float electricity = 0;
    private float water = 0;
    private float phone = 20;
    private float internet = 70;
    private float streamingServices = 30;
    private float debt = 50;
    private float debt2 =150;
    private float creditCard = 150;
    private float randomizable = 0;

    private float total = 0;

    private bool rentChecked = false;
    private bool electricityChecked = false;
    private bool waterChecked = false;
    private bool phoneChecked = false;
    private bool internetChecked = false;
    private bool streamingChecked = false;
    private bool debtChecked = false;
    private bool debt2Checked = false;
    private bool creditCardChecked = false;


    private void Awake()
    {
        rentButton.onClick.AddListener(delegate{CheckCheckboxes("rent"); });
        electricityButton.onClick.AddListener(delegate {CheckCheckboxes("electricity"); });
        waterButton.onClick.AddListener(delegate { CheckCheckboxes("water"); });
        phoneButton.onClick.AddListener(delegate { CheckCheckboxes("phone"); });
        internetButton.onClick.AddListener(delegate { CheckCheckboxes("internet"); });
        streamingButton.onClick.AddListener(delegate { CheckCheckboxes("streaming"); });
        debtButton.onClick.AddListener(delegate { CheckCheckboxes("debt"); });
        debt2Button.onClick.AddListener(delegate { CheckCheckboxes("debt2"); });
        creditCardButton.onClick.AddListener(delegate { CheckCheckboxes("creditcard"); }); 
    }

    // Start is called before the first frame update
    void Start()
    {
       // CalculateAndSetTotal();
    }

    // Update is called once per frame
    void Update()
    {
        //////////////TODO:
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        ///////////////

       // CalculateAndSetTotal();
    }




    void CheckCheckboxes(string checkbox) {

        switch (checkbox)
        {
            case "rent":
                if (rentChecked == false)
                {
                    rentChecked = true;
                    rentButton.image.sprite = checkedImage;
                    IncreaseTotal(rent);
                }
                else
                {
                    rentChecked = false;
                    rentButton.image.sprite = unCheckedImage;
                    DecreaseTotal(rent);
                }
                break;
            case "electricity":
                if (electricityChecked == false)
                {
                    electricityChecked = true;
                    electricityButton.image.sprite = checkedImage;
                    IncreaseTotal(electricity);
                }
                else
                {
                    electricityChecked = false;
                    electricityButton.image.sprite = unCheckedImage;
                    DecreaseTotal(electricity);
                }
                break;
            case "water":
                if (waterChecked == false)
                {
                    waterChecked = true;
                    waterButton.image.sprite = checkedImage;
                    IncreaseTotal(water);
                }
                else
                {
                    waterChecked = false;
                    waterButton.image.sprite = unCheckedImage;
                    DecreaseTotal(water);
                }
                break;
            case "phone":
                if (phoneChecked == false)
                {
                    phoneChecked = true;
                    phoneButton.image.sprite = checkedImage;
                    IncreaseTotal(phone);
                }
                else
                {
                    phoneChecked = false;
                    phoneButton.image.sprite = unCheckedImage;
                    DecreaseTotal(phone);
                }
                break; 
           case "internet":
                if (internetChecked == false)
                {
                    internetChecked = true;
                    internetButton.image.sprite = checkedImage;
                    IncreaseTotal(internet);
                }
                else
                {
                    internetChecked = false;
                    internetButton.image.sprite = unCheckedImage;
                    DecreaseTotal(internet);
                }
                break;
            case "streaming":
                if (streamingChecked == false)
                {
                    streamingChecked = true;
                    streamingButton.image.sprite = checkedImage;
                    IncreaseTotal(streamingServices);
                }
                else
                {
                    streamingChecked = false;
                    streamingButton.image.sprite = unCheckedImage;
                    DecreaseTotal(streamingServices);
                }
                break;
            case "debt":
                if (debtChecked == false)
                {
                    debtChecked = true;
                    debtButton.image.sprite = checkedImage;
                    IncreaseTotal(debt);
                }
                else
                {
                    debtChecked = false;
                    debtButton.image.sprite = unCheckedImage;
                    DecreaseTotal(debt);
                }

                break;
            case "debt2":
                if (debt2Checked == false)
                {
                    debt2Checked = true;
                    debt2Button.image.sprite = checkedImage;
                    IncreaseTotal(debt2);
                }
                else
                {
                    debt2Checked = false;
                    debt2Button.image.sprite = unCheckedImage;
                    DecreaseTotal(debt2);
                }
                break;
            case "creditcard":
                if (creditCardChecked == false)
                {
                    creditCardChecked = true;
                    creditCardButton.image.sprite = checkedImage;
                    IncreaseTotal(creditCard);
                }
                else
                {
                    creditCardChecked = false;
                    creditCardButton.image.sprite = unCheckedImage;
                    DecreaseTotal(creditCard);
                }

                break;
            default:
                break;
        }

    }
    
    public void SetRent(float amount)
    {
        this.rent += amount;
    }
    public void PayRent()
    {
        this.rent = 0;
    }
    public void SetElectricity(float amount)
    {
        this.electricity += amount;
    }
    public void PayElectricity()
    {
        this.electricity = 0;
    }
    public void SetWater(float amount)
    {
        this.water += amount;
    }
    public void PayWater()
    {
        this.water = 0;
    }
    public void SetPhone(float amount)
    {
        this.phone += amount;
    }
    public void PayPhone()
    {
        this.phone = 0;
    }
    public void SetInternet(float amount)
    {
        this.internet += amount;
    }
    public void PayInternet()
    {
        this.internet = 0;
    }
    public void SetStreamingServices(float amount)
    {
        this.streamingServices += amount;
    }
    public void PayStreamingServices()
    {
        this.streamingServices = 0;
    }
    public void SetDebt(float amount)
    {
        this.debt += amount;
    }
    public void PayDebt()
    {
        this.debt = 0;
    }
    public void SetDebt2(float amount)
    {
        this.debt2 += amount;
    }
    public void PayDebt2()
    {
        this.debt2 = 0;
    }
    public void SetCreditCard(float amount)
    {
        this.creditCard += amount;
    }
    public void PayCreditCard()
    {
        this.creditCard = 0;
    }
    //TODO: Needs probably randomizing function
    public void SetRandom(float amount)
    {
        this.randomizable += amount;
    }
    public void PayRandom()
    {
        this.randomizable = 0;
    }
    //private void CalculateAndSetTotal()
    //{

    //    //TODO: This could be done with an arrays also.. would it be cleaner

    //    if (rentChecked) { total += rent; }

    //    if (electricityChecked) { total += electricity; }
    //    if (waterChecked) { total += water; }
    //    if (phoneChecked) { total += phone; }
    //    if (internetChecked) { total += internet; }
    //    if (streamingChecked) { total += streamingServices; }
    //    if (debtChecked) { total += debt; }
    //    if (debt2Checked) { total += debt2; }
    //    if (creditCardChecked) { total += creditCard; }

    //    totalText.text = "Total: " + total.ToString();


    //}
    private void IncreaseTotal(float amount)
    {
        total += amount;
        totalText.text = "Total: " + total.ToString();
    }
    private void DecreaseTotal(float amount)
    {
        total -= amount;
        totalText.text = "Total: " + total.ToString();
    }
}
