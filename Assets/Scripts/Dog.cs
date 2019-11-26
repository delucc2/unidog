﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog : MonoBehaviour
{
    public float hunger = 0;
    public float loneliness = 0;
    public float fatigue = 0;
    public float contentment = 0;
    public float bathroom = 0;

    public float minSize = 2.5f;
    public float maxSize = 15;

    public GameObject hungerImg;
    public GameObject loneImg;
    public GameObject fatigueImg;
    public GameObject contentImg;
    public GameObject bathroomImg;

    private bool food_bowl = false;
    private bool is_playing = false;
    private bool at_work = false;

    private void Update()
    {
        hungerImg.transform.localScale = new Vector3(minSize,Mathf.Lerp(minSize, maxSize,  hunger / 100), minSize);
        loneImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, loneliness / 100), minSize);
        fatigueImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, fatigue / 100), minSize);
        contentImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, contentment / 100), minSize);
        bathroomImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, bathroom / 100), minSize);
    }

    public void fillFoodBowl()
    {
        food_bowl = true;
    }

    public void goToWork()
    {
        at_work = true;
    }

    public void comeHome()
    {
        at_work = false;
    }

    public void Hunger(float i)
    {
        hunger += i;
        hunger = Mathf.Max(i, 0);
        hunger = Mathf.Min(i, 100);
    }
    public void Loneliness(float i)
    {
        loneliness += i;
        loneliness = Mathf.Max(i, 0);
        loneliness = Mathf.Min(i, 100);
    }
    public void Fatigue(float i)
    {
        fatigue += i;
        fatigue = Mathf.Max(i, 0);
        fatigue = Mathf.Min(i, 100);
    }
    public void Contentment(float i)
    {
        contentment += i;
        contentment = Mathf.Max(i, 0);
        contentment = Mathf.Min(i, 100);
    }
    public void Bathroom(float i)
    {
        bathroom += i;
        bathroom = Mathf.Max(i, 0);
        bathroom = Mathf.Min(i, 100);
    }
}
