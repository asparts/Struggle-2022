using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{

    private const int TIMESCALE = 60; // larger number == Faster seconds

    public Text clockText;
    public Text dayText;
    public Text monthText;
    public Text seasonText;
    public Text yearText;
    public Text combinedText;

    public static double minute, hour, day, second, month, year;


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
        month = 1;
        day = 1;
        year = 2022;
        hour = 12;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();
        CalculateSeason();

        //CALLS TO GLOBALSTATS
        CallThirst();
        CallHunger();
        CallAnxiety();
        CallDepression();
        CallDirtiness();
        CallFatigue();

    }
    void TextCallFunction()
    {
        dayText.text = " / " + day;
        monthText.text = " / " + GetMonth(month);
        clockText.text = string.Format("  " + "{0:00}:{1:00}", hour, minute);
        yearText.text = "Year " + year;
        combinedText.text = "" + string.Format("  " + "{0:00}:{1:00}", hour, minute) + "  " + day + "" + GetDateEnding(day) + " of "+ GetMonth(month);
    }
    void CalculateSeason()
    {
        if(month == 12 || month == 1 || month == 2)
        {
            seasonText.text = "Winter";
        }
        if (month == 3 || month == 4 || month == 5)
        {
            seasonText.text = "Spring";
        }
        if (month == 6 || month == 7 || month == 8)
        {
            seasonText.text = "Summer";
        }
        if (month == 9 || month == 10 || month == 11)
        {
            seasonText.text = "Autumn";
        }
    }
    void CalculateMonth()
    {
        if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if(day >= 32)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }
        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 31)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }
        if (month == 2)
        {
            if (day >= 29)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }
    }
    void CalculateTime() {
        second += Time.deltaTime * TIMESCALE;
        if(second > 60)
        {
            minute++;
            second = 0;
            TextCallFunction();
        }else if(minute > 60)
        {
            hour++;
            minute = 0;
            TextCallFunction();
        }else if(hour > 24)
        {
            day++;
            hour = 0;
            TextCallFunction();
        }
        else if (day >= 28)
        {
            CalculateMonth();
        }
        else if (month >= 12)
        {
            month = 1;
            year++;
            TextCallFunction();
            CalculateMonth();
        }
    }
    private string GetMonth(double month)
    {

        if (month >= 1 && month <= 2) {
            return "January";
        } else if (month >= 2 && month <= 3) {
            return "February";
        } else if (month >= 3 && month <= 4) {
            return "March";
        } else if (month >= 4 && month <= 5) {
            return "April";
        } else if (month >= 5 && month <= 6) {
            return "May";
        } else if (month >= 6 && month <= 7) {
            return "June";
        } else if (month >= 7 && month <= 8) {
            return "July";
        } else if (month >= 8 && month <= 9) {
            return "August";
        } else if (month >= 9 && month <= 10) {
            return "September";
        }
        else if (month >= 10 && month <= 11)
        {
            return "October";
        }
        else if (month >= 11 && month <= 12)
        {
            return "November";
        }
        else if (month >= 12 && month < 13)
        {
            return "December";
        }
        else { return ""; }
    }
    private string GetDateEnding(double day) // cant remember what's the correct term for this
    {
        if (day >= 1 && day <= 2)
        {
            return "st";
        }
        else if (day >= 2 && day <= 3)
        {
            return "nd";
        }
        else if (day >= 3 && day <= 4)
        {
            return "rd";
        }
        else
        {
            return "th";
        }
    }

    public void addHours(double hours)
    {
        
    }

    // CALLS TO GLOBALSTATS TO MAINTAIN STATS
    private void CallWarmth() //TODO: Affected by clothes player wears
    {
        if (second % 6 == 0)
        {
            //globalStatsScript.DecreaseWarmth(0.15f);
        }
    }
    private void CallThirst()
    {
        if (second % 6 == 0)
        {
            globalStatsScript.AddThirst(0.15f);
        }
    }
    private void CallHunger()
    {
        if (second % 6 == 0)
        {
            globalStatsScript.AddHunger(0.15f);
        }
    }
    private void CallAnxiety()
    {
        if (second % 6 == 0)
        {
            globalStatsScript.AddAnxiety(0.15f);
        }
    }
    private void CallDepression()
    {
        if (second % 6 == 0)
        {
            globalStatsScript.AddDepression(0.15f);
        }
    }
    private void CallDirtiness()
    {
        if (second % 6 == 0)
        {
            globalStatsScript.AddDirtiness(0.15f);
        }
    }
    private void CallFatigue()
    {
        if (second % 6 == 0)
        {
            globalStatsScript.AddFatigue(0.15f);
        }
    }
    private void CallMoney()
    {
        if(day == 25)
        {
            globalStatsScript.AddMoney(2700);
        }
    }

}
