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
            doug.Loneliness(-10);
            Debug.Log("Doug whines as you leave for work.");
        }
        doug.goToWork();
    }

    [Task]
    void nuzzle()
    {
        if (!doug.atWork() && doug.loneliness >= 33 && doug.fatigue >= 66) {
            doug.Loneliness(-40);
            doug.Contentment(30);
            print("Doug nuzzles you.");
            Task.current.Succeed();
        } else {
            Task.current.Fail();
        }
    }

    public void getPets()
    {
        if (doug.contentment <= 80 && doug.enjoyingPets()) {
            doug.Loneliness(-20);
            doug.Contentment(10);
            print("Doug wags his tail.");
        } else if (doug.enjoyingPets()) {
            print("Doug abruptly runs away.");
            doug.noMorePets();
        } else {
            print("Doug moves his head away from your hand");
        }
    }

    public void getBellyRubs()
    {
        if (doug.contentment <= 75 && doug.enjoyingBellyRubs()) {
            doug.Loneliness(-30);
            doug.Contentment(25);
            print("Doug lays on his back for some glorious belly rubs");
        } else if (doug.enjoyingBellyRubs()) {
            print("Doug rolls back over, thoroughly satisfied");
            doug.noMoreBellyRubs();
        } else {
            print("Doug refuses to succumb to the belly rubs");
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
        //at_work = false;
    }
}
