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

    void Walk()
    {
        print("Doug runs back into the house.");
    }

    void home()
    {
        print("Doug tackles you as you open the door, licking your face and running around you.");
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
