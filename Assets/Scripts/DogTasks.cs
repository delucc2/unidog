using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogTasks : MonoBehaviour
{
    GameTime time;
    //Noise
    public void Noise()
    {
        time = GameObject.FindGameObjectWithTag("Player").GetComponent<GameTime>();
        if (time.hours >= 7 && time.am)
        {
            print("Doug looks towards the source of the noise breifly.");
        }
        else if (time.hours >= 10 && !time.am || time.hours < 7 && time.am)
        {
            print("Doug pauses and looks towards where the noise came from, extremely tense.");
        }
        else
        {
            print("Doug growls at the noise breifly, but then returns to his original state");
        }
    }
}
