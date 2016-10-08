using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Player player;
    public Enemy enemy;

    public Text ui_minute;
    public Text ui_hour;
    public Text ui_date;
    public Text ui_dayName;
    public Text ui_monthName;
    public Text ui_yearNumber;
    public Text ui_day;
    public Text ui_week;
    public Text ui_month;

    public Text ui_narration;

    public int minute;
    public int hour;
    public int date;

    public string dayName;
    public int day;
    public string[] dayList = new string[] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };

    public int numberOfDaysInMonth;
    public int month;
    public string monthName;
    public string[] monthList = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    public int[] monthLength = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public int numberOfMonthsInYear;
    public int year;

	// Use this for initialization
	void Start ()
    {

	}

    void fight()
    {
        BroadcastMessage("===FIGHT START===");
        int pAttack = player.attack();
        int eAttack = enemy.attack();

        int pDef = player.defend();
        int eDef = enemy.defend();

        if(pAttack > eDef)
        {
            //Player hits
            int dmg = player.attack();
            enemy.takeDamage(dmg);
            BroadcastMessage("You hit the BAD GUY NAME for - " + dmg + ".");

        }
        if(eAttack > pDef)
        {
            //Enemy Hits
            int dmg = enemy.attack();
            player.takeDamage(enemy.attack());
            BroadcastMessage("You get hit by the BAD GUY NAME for - " + dmg + ".");
        }
    }

    public void broadcast(string message)
    {

        ui_narration.text = message + "\n" + ui_narration.text;

        string[]tempText = ui_narration.text.Split('\n');
        ui_narration.text = tempText[0] + tempText[1] + tempText[2] + tempText[3] + tempText[4] + tempText[5] + tempText[6] + tempText[7];
    }

    public void rest()
    {
        player.rest(360);
        BroadcastMessage("You rested for six hours.");
        updateTime(360);
    }

    void updateTime(int _minute)
    {
        minute += _minute;
        if (minute >= 60)
        {
            hour += 1;
            minute = minute - 60;
            if(hour >= 24)
            {
                day += 1;
                dayName = dayList[day-1];
                hour = hour - 24;
                if(day > monthLength[month])
                {
                    month += 1;
                    monthName = monthList[ month-1];
                    day = 1;
                    if(month > numberOfMonthsInYear)
                    {
                        year += 1;
                        month = 1;
                    }
                }
            }
        }
        player.digestPrey(minute);
        updateDateUI();
    }

    void updateDateUI()
    {
        ui_minute.text = minute.ToString();
        ui_hour.text = hour.ToString();

        ui_dayName.text = dayName;
        ui_monthName.text = monthName;
        ui_yearNumber.text = year.ToString();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
