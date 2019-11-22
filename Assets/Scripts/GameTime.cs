using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    int hours;
    int minutes;
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
                hours = 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
