using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class HungryTasks : MonoBehaviour
{
    Dog doug;
    bool bothered;

    //Hungry
    [Task]
    void dogDish()
    {
        if (doug.hunger >= 100) {
            print("Doug goes to the dog dish and waits.");
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    void bother()
    {
        if (doug.hunger >= 50 && !bothered) {
            print("Doug bothers you.");
            bothered = true;
            Invoke("unbothered", 60);
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    void unbothered() { bothered = false; }

    [Task]
    void beg()
    {
        if (doug.contentment >= 75 && doug.hunger >= 50 && doug.hunger < 75) {
            print("Doug begs for a treat.");
            Task.current.Succeed();
        } else if (doug.hunger >= 75) {
            print("Doug is sad he was denied a treat.");
            doug.Contentment(-20);
            Task.current.Fail();
        }
    }

    [Task]
    void treat()
    {
        if (doug.treated()) {
            doug.Hunger(-20);
            doug.Contentment(20);
            doug.Bathroom(5);
            print("Doug snacks on a treat");
            doug.eatTreat();
            Task.current.Succeed();
        }
    }

    [Task]
    void eat()
    {
        if (doug.foodBowl()) {
            doug.Hunger(-100);
            doug.Bathroom(20);
            print("Doug eats his food.");
            Task.current.Succeed();
        }
    }

    void Start()
    {
        doug = GetComponent<Dog>();
        bothered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
