using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;

public class LonelyTasks : MonoBehaviour
{
    Dog doug;
    private bool at_work;

    //Lonely
    public void goingToWork()
    {
        if (doug.loneliness <= 50) {
            Debug.Log("Doug watches you leave for work.");
        } else {
            Debug.Log("Doug whines as you leave for work.");
        }
        doug.goToWork();
    }

    void nuzzle()
    {
        print("Doug nuzzles you.");
    }

    void enjoyingPets()
    {
        print("Doug wags his tail.");
    }

    void enoughPets()
    {
        print("Doug abruptly runs away.");
    }

    // Start is called before the first frame update
    void Start()
    {
        doug = GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        at_work = false;
    }
}
