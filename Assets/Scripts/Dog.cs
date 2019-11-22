using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog : MonoBehaviour
{
    public float hunger = 0;
    public float loneliness = 0;
    public float fatigue = 0;
    public float contenetment = 0;
    public float bathroom = 0;
    public float minSize = 2.5f;
    public float maxSize = 15;
    public GameObject hungerImg;
    public GameObject loneImg;
    public GameObject fatigueImg;
    public GameObject contentImg;
    public GameObject bathroomImg;

    private void Update()
    {
        hungerImg.transform.localScale = new Vector3(minSize,Mathf.Lerp(minSize, maxSize,  hunger / 100), minSize);
    }
}
