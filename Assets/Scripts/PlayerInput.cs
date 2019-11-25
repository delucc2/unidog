using System.Collections;
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
                        Debug.Log("Put food in the dog bowl");
                        doug.fillFoodBowl();
                        return;
                    case 't':
                        Debug.Log("Gave the dog a treat");
                        return;
                    case 'k':
                        Debug.Log("Threw the stick");
                        return;
                    case 'p':
                        Debug.Log("Pet the dog");
                        return;
                    case 'b':
                        Debug.Log("Rubbed the dog's belly");
                        return;
                    case 'w':
                        Debug.Log("Took the dog for a walk");
                        return;
                    case 'l':
                        Debug.Log("Left the dog alone");
                        return;
                    case 'g':
                        Debug.Log("Went to work");
                        lonely.goingToWork();
                        return;
                    case 'a':
                        Debug.Log("Return home from work");
                        return;
                    case 'i':
                        Debug.Log("Wait fifteen minutes");
                        clock.updateTime(true, false);
                        return;
                    case 'h':
                        Debug.Log("Wait one hour");
                        clock.updateTime(false, true);
                        return;
                    case 'd':
                        Debug.Log("Wait one day");
                        return;
                    case 's':
                        Debug.Log("Played a strange sound");
                        return;
                    default:
                        return;
                }                      
            }
        }
    }
}
