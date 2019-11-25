using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class TiredTasks : MonoBehaviour
{
    private Dog doug;
    private bool is_sleepy;
    private GameTime clock;

    [Task]
    public void sleepy()
    {
        if (!is_sleepy && doug.fatigue >= 75) {
            Debug.Log("Doug is sleepy.");
            is_sleepy = true;
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    public void sleep()
    {
        if (is_sleepy && doug.fatigue >= 100)
        {
            Debug.Log("Doug goes to sleep.");
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    [Task]
    public void irritated()
    {
        print("Doug is irritated.");
    }

    [Task]
    public void wake()
    {
        print("Doug wakes up.");
        is_sleepy = false;
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
