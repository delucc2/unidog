using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOutTasks : MonoBehaviour
{

    Dog doug;

    //Go Out
    void Need()
    {
        doug.Loneliness(5);
        print("Doug begins scratching the door, barking.");
    }

    void walk()
    {
        doug.Loneliness(-10);
        doug.Fatigue(50);
        print("Doug walks before you on his leash.");
    }

    void toilet()
    {
        doug.Bathroom(-100);
        print("Doug performs his business outside on the grass.");
    }

    void returnHome()
    {
        print("Doug runs into the house pulling you behind him.");
    }

    void Start()
    {
        doug = GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
