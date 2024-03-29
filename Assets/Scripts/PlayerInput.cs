﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Dog doug;
    GameTime clock;
    TiredTasks tired;
    LonelyTasks lonely;
    PlayTasks play;
    HungryTasks hungry;
    GoOutTasks go_out;
    DogTasks generic_tasks;

    private bool work = false;

    // Start is called before the first frame update
    void Start()
    {
        doug = GameObject.Find("Dog").GetComponent<Dog>();
        clock = gameObject.GetComponent<GameTime>();

        tired = doug.GetComponent<TiredTasks>();
        lonely = doug.GetComponent<LonelyTasks>();
        play = doug.GetComponent<PlayTasks>();
        hungry = doug.GetComponent<HungryTasks>();
        go_out = doug.GetComponent<GoOutTasks>();
        generic_tasks = doug.GetComponent<DogTasks>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (char a in Input.inputString)
            {
                switch (a)
                {
                    case 'f':
                        if (!work)
                        {
                            Debug.Log("Put food in Doug's bowl");
                            doug.fillFoodBowl();
                            clock.updateTime(0);
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 't':
                        if (!work)
                        {
                            Debug.Log("Gave Doug a treat");
                            doug.setTreat();
                            clock.updateTime(0);
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 'k':
                        if (!work)
                        {
                            Debug.Log("Threw the stick past Doug");
                            clock.updateTime(0);
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 'p':
                        if (!work)
                        {
                            Debug.Log("Pet Doug");
                            clock.updateTime(0);
                            lonely.getPets();
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 'b':
                        if (!work)
                        {
                            Debug.Log("Rubbed Doug's belly");
                            clock.updateTime(0);
                            lonely.getBellyRubs();
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 'w':
                        if (!work)
                        {
                            Debug.Log("Took Doug for a walk");
                            doug.onAWalk();
                            clock.updateTime(0);
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 'l':
                        if (!work)
                        {
                            Debug.Log("Left Doug alone");
                            clock.updateTime(0);
                        }
                        else
                        {
                            Debug.Log("I can't do that, I'm at work");
                        }
                        return;
                    case 'g':
                        if (!work)
                        {
                            Debug.Log("Went to work");
                            work = true;
                            clock.updateTime(0);
                            lonely.goingToWork();
                        }
                        else
                        {
                            Debug.Log("I'm already at work");
                        }
                        return;
                    case 'a':
                        if (work)
                        {
                            Debug.Log("Return home from work");
                            work = false;
                            clock.updateTime(0);
                        }
                        else
                        {
                            Debug.Log("I'm already home");
                        }
                        return;
                    case 'i':
                        Debug.Log("Wait fifteen minutes");
                        clock.updateTime(0);
                        return;
                    case 'h':
                        Debug.Log("Wait one hour");
                        clock.updateTime(1);
                        return;
                    case 'd':
                        Debug.Log("Wait one day");
                        clock.updateTime(2);
                        return;
                    case 's':
                        Debug.Log("Played a strange sound");
                        clock.updateTime(0);
                        generic_tasks.Noise();
                        return;
                    default:
                        return;
                }                      
            }
        }
    }
}
