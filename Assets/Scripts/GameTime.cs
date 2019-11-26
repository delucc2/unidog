using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public int hours;
    int minutes;
    string currTime;
    string AMPM = "AM";
    public bool am = true;
    public Text CanvasArea;
    Dog doug;
    
    // Start is called before the first frame update
    void Start()
    {
        hours = 7;
        minutes = 0;

        doug = GameObject.Find("Dog").GetComponent<Dog>();
    }

    public void incrementTime(int i)
    {
        minutes += i;
        if (minutes >= 60)
        {
            hours += 1;
            minutes -= 60;
        }

        doug.contentment -= i / 6;
        doug.contentment = Mathf.Max(doug.contentment, 0);

        doug.fatigue -= i / 8;
        doug.fatigue = Mathf.Max(doug.fatigue, 0);

        doug.hunger += i / 6;
        doug.hunger = Mathf.Min(doug.hunger, 100);

        doug.loneliness += i / 4;
        doug.loneliness = Mathf.Min(doug.loneliness, 100);

        doug.bathroom += i / 3;
        doug.bathroom = Mathf.Min(doug.bathroom, 100);
    }

    public void updateTime(int i)
    {
        if (i == 0)
        {
            incrementTime(15);
        }
        if (i == 1)
        {
            incrementTime(60);
        }
        if (i == 2)
        {
            while(hours != 7 || am == false || minutes != 0)
            {
                incrementTime(15);
                checkHours();
            }
        }
        checkHours();
    }

    void checkHours()
    {
        if (hours > 12)
        {
            if (am)
            {
                am = false;
                AMPM = "PM";
            }
            else
            {
                am = true;
                AMPM = "AM";
            }
            hours = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        System.TimeSpan current = System.TimeSpan.FromMinutes(hours * 60 + minutes);
        currTime = current.ToString();
        currTime = currTime.Remove(5);
        CanvasArea.text = string.Format("{0} {1} ", currTime, AMPM);
    }
}
