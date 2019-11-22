﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    int hours;
    int minutes;
    string currTime;
    string AMPM = "AM";
    bool am = true;
    public Text CanvasArea; 
    
    // Start is called before the first frame update
    void Start()
    {
        hours = 7;
        minutes = 0;
    }

    void incrementTime(int i)
    {
        minutes += i;
        if (minutes >= 60)
        {
            hours += 1;
            minutes -= 60;
        }
    }

    void updateTime(bool i, bool h)
    {
        if (i)
        {
            incrementTime(15);
        }
        if (h)
        {
            hours += 1;
            if(hours > 12)
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
