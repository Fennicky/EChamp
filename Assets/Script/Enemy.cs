using UnityEngine;
using System.Collections;

public class Enemy : Character {


    public int xp;
    public int level;
    public int levelUpCost;
    public int baseLevelUpCost = 1000;


    // Use this for initialization
    void Start()
    {

    }

    void newenemy()
    {
        name = "Adam";
        xp = 0;
        level = 1;
        setCounters();
    }

    public void heal(int h)
    {
        health += h;
        setCounters();
    }

    public void genMana(int m)
    {
        magic += m;
        setCounters();
    }

    void gutDigest(int hours)
    {
        int StomachToGut = 0;

        //Digest in stomach
        foreach (Character c in stomachContents)
        {
            if (c.health > 0)
            {
                c.health -= stomachStrength * hours;
            }
            else
            {
                //remove mass and move to guts
                StomachToGut += stomachStrength * hours;
                c.mass -= stomachStrength * hours;
                if (c.mass <= 0)
                {
                    StomachToGut += c.mass * hours;
                    c.digested = true;
                }
            }
        }

        gutFill += StomachToGut * hours;
        gutFill -= gutSpeed * hours;

        if (gutFill > gutCapacity)
        {
            //GUT CRAMP
            Debug.Log("Gut cramps. Fill: " + gutFill + "Cap: " + gutCapacity);
        }

        //Move from guts to bowels
        bowelFill += gutSpeed * hours;

        //Check how much they need to SHIT
        if (bowelFill > bowelCapacity)
        {
            //BOWEL CRAMP
            Debug.Log("Bowel cramps. Fill: " + bowelFill + "Cap: " + bowelCapacity);
        }
    }

    void ballDigest(int hours)
    {
        foreach (Character c in ballContents)
        {
            if (c.health > 0)
            {
                c.health -= ballSpeed * hours;
            }
            else
            {
                c.mass -= ballSpeed * hours;
                if (c.mass <= 0)
                {
                    c.digested = true;
                }
            }
        }
    }

    void coochDigest(int hours)
    {
        foreach (Character c in coochContents)
        {
            if (c.health > 0)
            {
                c.health -= coochSpeed * hours;
            }
            else
            {
                c.mass -= coochSpeed * hours;
                if (c.mass <= 0)
                {
                    c.digested = true;
                }
            }
        }
    }

    int jerkOff()
    {
        int load = 0;
        //jerk off code

            //Always able to jerk it
            load += jizz / 6;
            jizz -= load;
            lust = 0;
       
        return load;
    }

    void turnOn(int sexiness)
    {
        lust += sexiness;

        if (lust == 100)
        {
            lust = 100;
            sexKO = true;
        }
        setCounters();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
