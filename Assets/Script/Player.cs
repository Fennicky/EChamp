using UnityEngine;
using System.Collections;


public class Player : Character {

    //Character player;
    public Game game;

    public int xp;
    public int level;
    public int levelUpCost;
    public int baseLevelUpCost = 1000;


    public int hunger;
    public int sleep;

    // Use this for initialization
    void Start () {
	
	}
	
    void newPlayer()
    {
        name = "Eden";
        xp = 0;
        level = 1;
        levelUpCost = 1000;

        setCounters();
    }

    void awardXp(int _xp)
    {
       xp += _xp;
        if(xp >= levelUpCost)
        {
            levelUp();
        }
        //Heal/refill stuff
        health = maxHealth;
        magic = maxMagic;

        //Level up screen/stat distribution

        setCounters();
    }

    void levelUp()
    {

        level += 1;
        xp -= levelUpCost;
        levelUpCost = level *= (baseLevelUpCost + level*125 )*level;
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

    public void rest(int _minutes)
    {
        int hours = 60 / _minutes;
        gutDigest(hours);
        ballDigest(hours);
        coochDigest(hours);
        turnOn(lustRate * hours);

        health += health / 10 * hours;
        magic += magic / 10 * hours;
        stamina += _minutes * 10;

    }

    public void digestPrey(int _minutes)
    {
        int hours = 60/_minutes;
        gutDigest(hours);
        ballDigest(hours);
        coochDigest(hours);
        lust += lustRate * hours;
    }

    void gutDigest(int hours)
    {
        int StomachToGut = 0;

        //Digest in stomach
        foreach(Character c in stomachContents)
        {
            if(c.health > 0)
            {
                c.health -= stomachStrength * hours;
            }
            else
            {
                //remove mass and move to guts
                StomachToGut += stomachStrength * hours;
                c.mass -= stomachStrength * hours;
                if(c.mass <= 0)
                {
                    StomachToGut += c.mass * hours;
                    c.digested = true;
                }
            }
            setCounters();
        }

        gutFill += StomachToGut * hours;
        gutFill -= gutSpeed * hours;

        if(gutFill > gutCapacity)
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
        setCounters();
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
        setCounters();
    }

    int jerkOff()
    {
        int load = 0;
        //jerk off code
        if(lust > 25)
        {
            //Able to jerk it
            load += jizz/6;
            jizz -= load;
            lust = 0;
        }
        {
            //Unable to jerk it
            load = 0;
        }
        setCounters();
        return load;        
    }

    public void shit()
    {

        int shitAmount = bowelFill - 20;
        if(shitAmount < 0)
        {
            shitAmount = 0;
        }
        if (shitAmount == 0)
        {
            //Can't shit
        }
        else
        {
            //SHIT
            bowelFill -= shitAmount;
        }


    }

    void turnOn(int sexiness)
    {
        lust += sexiness;

        if(lust == 100)
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
