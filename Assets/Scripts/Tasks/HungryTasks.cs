using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryTasks : MonoBehaviour
{
    Dog doug;
    //Hungry
    void dogDish()
    {
        print("Doug goes to the dog dish.");
    }

    void bother()
    {
        print("Doug bothers you.");
    }

    void beg()
    {
        print("Doug begs for a treat.");
    }

    void eat()
    {
        doug.Hunger(-50);
        doug.Bathroom(20);
        print("Doug eats his food.");
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
