using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class TiredTasks : MonoBehaviour
{
    private Dog doug;
    private GameTime clock;

    [Task]
    public void sleepy()
    {
        if (doug.fatigue >= 75 && doug.fatigue < 100) {
            Debug.Log("Doug is sleepy.");
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    public void sleep()
    {
        if (doug.fatigue >= 100 || Input.GetKeyDown(KeyCode.L)) {
            Debug.Log("Doug goes to sleep.");
            Task.current.Succeed();
        }
    }

    [Task]
    public void wake()
    {
        print("Doug wakes up.");
        doug.fatigue = 0;
        clock.incrementTime(60);
        Task.current.Succeed();
    }

    // Start is called before the first frame update
    void Start()
    {
        doug = gameObject.GetComponent<Dog>();
        clock = GameObject.Find("Player").GetComponent<GameTime>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
