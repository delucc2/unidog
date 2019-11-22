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
                    case 'i':
                        Debug.Log("Advanced fifteen minutes");
                        return;
                    case 'h':
                        Debug.Log("Advanced one hour");
                        return;
                    default:
                        return;
                }                      
            }
        }
    }
}
