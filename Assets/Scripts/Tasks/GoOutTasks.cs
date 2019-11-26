using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class GoOutTasks : MonoBehaviour
{

    Dog doug;
    bool needs_to_go;

    //Go Out
    void Need()
    {
        if (doug.bathroom >= 75 && !(doug.isPlaying() || doug.onAWalk())) {
            doug.Loneliness(5);
            print("Doug begins scratching the door, barking.");
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    void wantsWalk()
    {
        if (doug.loneliness >= 75 || doug.contentment <= 25) {
            print("Doug looks longingly at the door...");
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    void walk()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            doug.Loneliness(-10);
            doug.Fatigue(50);
            print("Doug walks before you on his leash.");
            Task.current.Succeed();
        }
    }

    [Task]
    void toilet()
    {
        if (doug.bathroom >= 75 && (doug.isPlaying() || doug.onAWalk())) {
            doug.Bathroom(-100);
            print("Doug performs his business outside on the grass.");
            Task.current.Succeed();
        }
            
    }

    [Task]
    void returnHome()
    {
        print("Doug runs into the house pulling you behind him.");
        Task.current.Succeed();
    }

    void Start()
    {
        doug = GetComponent<Dog>();
        needs_to_go = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
