using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    int hours;
    int minutes;
    // Start is called before the first frame update
    void Start()
    {
        hours = 12;
        minutes = 0;
    }

    void updateTime(bool i, bool h)
    {
        if (i)
        {
            minutes += 15;
            if (minutes == 60)
            {
                hours += 1;
                minutes = 0;
            }
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
