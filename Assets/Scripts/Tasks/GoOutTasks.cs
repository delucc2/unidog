using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class GoOutTasks : MonoBehaviour
{

    Dog doug;
    bool needs_to_go;
    bool wants_walk;
    GameTime clock;

    //Go Out
    [Task]
    void Need()
    {
        if (doug.bathroom >= 75 && !needs_to_go) {
            doug.Loneliness(5);
            print("Doug begins scratching the door, barking.");
            needs_to_go = true;
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    void wantsWalk()
    {
        if ((doug.loneliness >= 75 || doug.contentment <= 25) && doug.fatigue < 75 && doug.fatigue >= 35 && doug.hunger < 75 && !wants_walk) {
            print("Doug looks longingly at the door...");
            wants_walk = true;
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    void walk()
    {
        if (Input.GetKeyDown(KeyCode.W) && doug.fatigue >= 35) {
            doug.Loneliness(-10);
            doug.Fatigue(50);
            print("Doug happily walks before you on his leash.");
            Task.current.Succeed();
        } else if (Input.GetKeyDown(KeyCode.W) && doug.fatigue < 35) {
            doug.Loneliness(-25);
            doug.Fatigue(75);
            print("Doug goes on a long and exciting walk with you!");
            clock.updateTime(1);
            Task.current.Succeed();
        }
    }

    [Task]
    void toilet()
    {
        if (doug.bathroom >= 75) {
            doug.Bathroom(-100);
            print("Doug performs his business outside on the grass.");
            needs_to_go = false;
            Task.current.Succeed();
        } else {
            Task.current.Succeed();
        }
            
    }

    [Task]
    void returnHome()
    {
        print("Doug runs into the house pulling you behind him.");
        wants_walk = false;
        Task.current.Succeed();
    }

    void Start()
    {
        doug = GetComponent<Dog>();
        needs_to_go = false;
        wants_walk = false;

        clock = GameObject.Find("Player").GetComponent<GameTime>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
