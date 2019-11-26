using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTasks : MonoBehaviour
{
    Dog doug;
    //Play
    void wantToPlay()
    {
        print("Doug jumps around expectingly.");
    }

    void getReadyForFetch()
    {
        print("Doug kneels before you wagging his tail.");
    }

    void fetch()
    {
        doug.Loneliness(-20);
        doug.Fatigue(25);
        print("Doug runs after the stick, coming back with it in his mouth.");
    }

    void boredFetch()
    {
        print("Doug looks at the stick flying away and back at you.");
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
