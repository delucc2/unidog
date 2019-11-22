using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
                        return;
                    case 'a':
                        Debug.Log("Return home from work");
                        return;
                    case 'i':
                        Debug.Log("Wait fifteen minutes");
                        return;
                    case 'h':
                        Debug.Log("Wait one hour");
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
