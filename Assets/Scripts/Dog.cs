using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Panda;

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
    private bool enjoying_pets = true;
    private bool enjoying_bellyrubs = true;
    private bool treat = false;

    public bool foodBowl() { return food_bowl; }
    public bool isPlaying() { return is_playing; }
    public bool atWork() { return at_work; }
    public bool enjoyingPets() { return enjoying_pets; }
    public bool enjoyingBellyRubs() { return enjoying_bellyrubs; }
    public bool treated() { return treat; }

    public void fillFoodBowl() { food_bowl = true; }
    public void eatFoodBowl() { food_bowl = false; }

    public void goToWork() { at_work = true; }
    public void comeHome() { at_work = false; }

    public void readyForPets() { enjoying_pets = true; }
    public void noMorePets() { enjoying_pets = false; }

    public void readyForBellyRubs() { enjoying_bellyrubs = true; }
    public void noMoreBellyRubs() { enjoying_bellyrubs = false; }

    public void setTreat() { treat = true; }
    public void eatTreat() { treat = false; }

    //Only the dog can change its own stats
    //The dog may not accept the actions of the payer so the stat changes should reflect this
    private void Update()
    {
        hungerImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, hunger / 100), minSize);
        loneImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, loneliness / 100), minSize);
        fatigueImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, fatigue / 100), minSize);
        contentImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, contentment / 100), minSize);
        bathroomImg.transform.localScale = new Vector3(minSize, Mathf.Lerp(minSize, maxSize, bathroom / 100), minSize);
    }

    public void Hunger(float i)
    {
        hunger += i;
        hunger = Mathf.Max(hunger, 0);
        hunger = Mathf.Min(hunger, 100);
    }
    public void Loneliness(float i)
    {
        loneliness += i;
        loneliness = Mathf.Max(loneliness, 0);
        loneliness = Mathf.Min(loneliness, 100);
    }
    public void Fatigue(float i)
    {
        fatigue += i;
        fatigue = Mathf.Max(fatigue, 0);
        fatigue = Mathf.Min(fatigue, 100);
    }
    public void Contentment(float i)
    {
        contentment += i;
        contentment = Mathf.Max(contentment, 0);
        contentment = Mathf.Min(contentment, 100);
    }
    public void Bathroom(float i)
    {
        bathroom += i;
        bathroom = Mathf.Max(bathroom, 0);
        bathroom = Mathf.Min(bathroom, 100);
    }
}
