using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class PlayTasks : MonoBehaviour
{
    Dog doug;

    //Play
    [Task]
    void wantToPlay()
    {
        if (doug.fatigue <= 25 && doug.contentment <= 50 && doug.hunger < 75 && !doug.wantsToPlay()) {
            print("Doug jumps around expectingly.");
            doug.readyToPlay();
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    void getReadyForFetch()
    {
        print("Doug kneels before you wagging his tail, ready for some fetch!");
        Task.current.Succeed();
    }

    [Task]
    void fetch()
    {
        if (doug.fatigue <= 80 && Input.GetKeyDown(KeyCode.K)) {
            doug.Contentment(20);
            doug.Fatigue(25);
            print("Doug runs after the stick, coming back with it in his mouth.");
        } else if (Input.GetKeyDown(KeyCode.K)) {
            print("Doug looks at the stick flying away and back at you.");
            Task.current.Succeed();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        doug = GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
