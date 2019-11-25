using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogTasks : MonoBehaviour
{
    GameTime time;
    //Noise
    void Noise()
    {
        time = GameObject.FindGameObjectWithTag("Player").GetComponent<GameTime>();
        if(time.hours >= 7 && time.am)
        {
            print("Doug looks towards the source of the noise breifly.");
        }
        else if (time.hours >= 10 && !time.am || time.hours < 7 && time.am)
        {
            print("Doug pauses and looks towards where the noise came from, extremely tense.");
        }
        else
        {
            print("Doug growls at the noise breifly, but then returns to his original state");
        }
    }

    //Positive Reactions
    void EatFood()
    {
        print("Doug walks to his food bowl and eats.");
    }

    void EatTreat()
    {
        print("Doug eats the treat from your hands.");
    }

    void FetchStick()
    {
        print("Doug runs after the stick. He brings it back in his mouth.");
    }

    void Pet()
    {
        print("Doug wags his tail.");
    }

    void Belly()
    {
        print("Doug wags his tail and smiles with his mouth open, laying face up.");
    }

    void house()
    {
        print("Doug runs back into the house.");
    }

    void home()
    {
        print("Doug tackles you as you open the door, licking your face and running around you.");
    }

    //Negative Reactions 
    void Ignore()
    {
        print("Doug ignores you.");
    }

    void WalkAway()
    {
        print("Doug walks away from you and goes to another room.");
    }

    void bark()
    {
        print("Doug barks at you.");
    }

    void whine()
    {
        print("Doug whines at you.");
    }

    void laydown()
    {
        print("Doug lays down on the floor.");
    }

    void sit()
    {
        print("Doug sits on the floor.");
    }

    void scratch()
    {
        print("Doug scratches himself");
    }

    void look()
    {
        print("Doug looks at you.");
    }

    void wake()
    {
        print("Doug wakes up.");
    }

    void yawn()
    {
        print("Doug yawns.");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
