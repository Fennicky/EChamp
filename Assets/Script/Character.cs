using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Character : MonoBehaviour{

    public delegate void Use();
    public static event Use use;

    public string charName;
    //Base stats
    public int health;
    public int magic;
    public int maxHealth;
    public int maxMagic;
    public int lust;
    public int lustRate;


    public float height;
    public int mass;
    public int fat;
    public string pronoun;
    public string gender;
    public bool taur;
    public bool goop;
    public bool micro;
    public bool macro;
    public bool tail;
    public int tailSize;
    public string tailType;
    public bool wings;

    //Action slots
    public Action action1;
    public Action action2;
    public Action action3;
    public Action action4;
    public Action action5;
    public Action action6;

    public Action[] actionList = new Action[6];


    //Inv slots
    public Item headgear;
    public Item shirt;
    public Item underwear;
    public Item pants;
    public Item boots;
    public Item socks;
    public Item gloves;
    public Item bracers;
    public Item ring1;
    public Item ring2;
    public Item ring3;
    public Item ring4;
    public Item ring5;
    public Item ring6;
    public Item ring7;
    public Item ring8;

    public Item weapon;

    public bool inventoryFull;


    //Species stuff

    [Range(0.0f, 100f)]
    public int human;
    [Range(0.0f, 100f)]
    public int fox;
    [Range(0.0f, 100f)]
    public int wolf;
    [Range(0.0f, 100f)]
    public int dog;
    [Range(0.0f, 100f)]
    public int dragon;
    [Range(0.0f, 100f)]
    public int gecko;
    [Range(0.0f, 100f)]
    public int cameleon;
    [Range(0.0f, 100f)]
    public int kangaroo;
    [Range(0.0f, 100f)]
    public int ferret;
    [Range(0.0f, 100f)]
    public int skunk;
    [Range(0.0f, 100f)]
    public int weasel;
    [Range(0.0f, 100f)]
    public int cat;
    [Range(0.0f, 100f)]
    public int tiger;
    [Range(0.0f, 100f)]
    public int lion;
    [Range(0.0f, 100f)]
    public int leopard;
    [Range(0.0f, 100f)]
    public int deer;
    [Range(0.0f, 100f)]
    public int reigndeer;
    [Range(0.0f, 100f)]
    public int horse;
    [Range(0.0f, 100f)]
    public int zebra;
    [Range(0.0f, 100f)]
    public int giraffe;
    [Range(0.0f, 100f)]
    public int speed;
    [Range(0.0f, 100f)]
    public int smarts;
    [Range(0.0f, 100f)]
    public int strength;
    [Range(0.0f, 100f)]
    public int defense;
    [Range(0.0f, 100f)]
    public int stamina;
    [Range(0.0f, 100f)]
    public int agility;
    [Range(0.0f, 100f)]
    public int charisma;
    [Range(0.0f, 100f)]
    public int armour;
    [Range(0.0f, 100f)]

    public bool awake;
    public bool dead;
    public bool digested;
    public bool sexKO;

    public bool canBeEaten;
    public bool eaten;

    public bool eats;
    public int stomachCapacity;
    public int stomachStrength;
    public int gutFill;
    public int gutCapacity;
    public int gutSpeed;
    public int bowelFill;
    public int bowelCapacity;
    public int bowelResistance;
    public ArrayList stomachContents = new ArrayList();

    public bool dick;
    public int dickSize;
    public int dickGirth;

    public bool balls;
    public int ballCount;
    public int ballSize;
    public int ballFill;
    public int jizz;
    public int preyJizz;
    public int ballCapacity;
    public int ballSpeed;
    public bool cockVoreEnabled;
    public ArrayList ballContents = new ArrayList();

    public bool cooch;
    public int coochCount;
    public int coochSize;
    public int coochFill;
    public int sheJizz;
    public int coochCapacity;
    public int coochSpeed;
    public bool coochVoreEnabled;
    public ArrayList coochContents = new ArrayList();

    public bool tits;
    public int titSize;
    public int titCount;
    public int titFill;
    public int milk;
    public int titCapacity;
    public int titSpeed;
    public bool titVoreEnabled;
    public ArrayList titContents = new ArrayList();

    public bool ass;
    public int assSize;
    public int assFill;
    public int assCapacity;
    public int assSpeed;
    public bool assVoreEnabled;
    public ArrayList assContents = new ArrayList();

    public Text ui_name;
    public Text ui_health;
    public Text ui_mana;
    public Text ui_stamina;
    public Text ui_speed;
    public Text ui_def;
    public Text ui_agility;
    public Text ui_lust;
    public Text ui_sleep;
    public Text ui_hunger;
    public Text ui_xp;
    public Text ui_level;


    public ArrayList inventory;

    public void setSpecies(string s)
    {

    }

    

	// Use this for initialization
	void Start () {


	}

    public void setAction(int i, Action a)
    {
        switch (i)
        {
            case 1:
                actionList[0] = a;
                break;

            case 2:
                actionList[1] = a;
                break;

            case 3:
                actionList[2] = a;
                break;

            case 4:
                actionList[3] = a;
                break;

            case 5:
                actionList[4] = a;
                break;

            case 6:
                actionList[5] = a;
                break;
        }
    }

    public void Action(int i)
    {
        switch (i)
        {
            case 0:
                action1.use();
                break;

            case 1:
                action2.use();
                break;

            case 2:
                action3.use();
                break;

            case 3:
                action4.use();
                break;


            case 4:
                action5.use();
                break;

            case 5:
                action6.use();
                break;

        }
    }

    void initBasicSpecies()
    {
        human = 100;

        fox = 0;
        wolf = 0;
        dog = 0;

        dragon = 0;
        gecko = 0;
        cameleon = 0;

        kangaroo = 0;
        ferret = 0;
        skunk = 0;
        weasel = 0;

        cat = 0;
        tiger = 0;
        lion = 0;
        leopard = 0;

        deer = 0;
        reigndeer = 0;
        horse = 0;
        zebra = 0;
        giraffe = 0;
}

    void initBasicStats()
    {
        health = 100;
        magic = 100;

        height = 72;
        mass = 180;
        taur = false;
        goop = false;
        micro = false;
        macro = false;
        tail = false;
        tailSize = 0;
        tailType = "0";

        speed = 100;
        smarts = 100;
        strength = 100;
        defense = 20;
        stamina = 100;
        agility = 100;
        charisma = 100;

        awake = false;
        dead = false;

        canBeEaten = true;
        eaten = false;

        eats = true;
        stomachCapacity = 10;
        stomachStrength = 1;
        gutCapacity = 10;
        gutSpeed = 1;
        bowelCapacity = 10;
        bowelResistance = 1;
}

    void makeFemale()
    {
        pronoun = "She";
        gender = "Female";

        dick = false;
        dickSize = 0;
        dickGirth = 0;

        balls = false;
        ballCount = 0;
        ballSize = 0;
        ballCapacity = 0;
        cockVoreEnabled = false;

        cooch = true;
        coochCount = 1;
        coochSize = 6;
        coochCapacity = 9;
        coochVoreEnabled = true;

        tits = true;
        titSize = 8;
        titCount = 1;
        titCapacity = 0;
        titVoreEnabled = false;

        ass = true;
        assSize = 10;
        assCapacity = 9;
        assVoreEnabled = true;
}

    void makeMale()
    {
        pronoun = "He";
        gender = "Male";

        dick = true;
        dickSize = 6;
        dickGirth = 3;

        balls = true;
        ballCount = 1;
        ballSize = 6;
        ballCapacity = 9;
        cockVoreEnabled = false;

        cooch = false;
        coochCount = 0;
        coochSize = 0;
        coochCapacity = 0;
        coochVoreEnabled = false;

        tits = false;
        titSize = 0;
        titCount = 0;
        titCapacity = 0;
        titVoreEnabled = false;

        ass = true;
        assSize = 10;
        assCapacity = 9;
        assVoreEnabled = true;
    }

    void makeHerm()
    {
        pronoun = "They";
        gender = "Herm";

        dick = true;
        dickSize = 6;
        dickGirth = 3;

        balls = true;
        ballCount = 1;
        ballSize = 6;
        ballCapacity = 9;
        cockVoreEnabled = false;

        cooch = true;
        coochCount = 1;
        coochSize = 6;
        coochCapacity = 9;
        coochVoreEnabled = true;

        tits = true;
        titSize = 8;
        titCount = 1;
        titCapacity = 0;
        titVoreEnabled = false;

        ass = true;
        assSize = 10;
        assCapacity = 9;
        assVoreEnabled = true;
    }

    void equip(Item item)
    {
        int inventorySafesaver = item.invSlot;
        switch (item.slot)
        {
            case "food":
                use += item.effect;
                use();
                use -= item.effect;
                break;

            case "weapon":

                if (weapon != null)
                {
                    weapon.unequip();
                    inventory[inventorySafesaver] = weapon;
                }
                weapon = item;
                break;

            case "head":
                if (headgear != null)
                {
                    headgear.unequip();
                    inventory[inventorySafesaver] = headgear;
                }
                headgear = item;
                break;

            case "shirt":
                if (shirt != null)
                {
                    shirt.unequip();
                    inventory[inventorySafesaver] = shirt;
                }
                shirt = item;
                break;

            case "underwear":
                if (underwear != null)
                {
                    underwear.unequip();
                    inventory[inventorySafesaver] = underwear;
                }
                underwear = item;
                break;

            case "pants":
                if (pants != null)
                {
                    pants.unequip();
                    inventory[inventorySafesaver] = pants;
                }
                pants = item;
                break;

            case "boots":
                if (boots != null)
                {
                    boots.unequip();
                    inventory[inventorySafesaver] = headgear;
                }
                boots = item;
                break;

            case "socks":
                if (socks != null)
                {
                    socks.unequip();
                    inventory[inventorySafesaver] = socks;
                }
                socks = item;
                break;

            case "gloves":
                if (gloves != null)
                {
                    gloves.unequip();
                    inventory[inventorySafesaver] = gloves;
                }
                gloves = item;
                break;

            case "bracers":
                if (bracers != null)
                {
                    bracers.unequip();
                    inventory[inventorySafesaver] = bracers;
                }
                bracers = item;
                break;

            case "ring1":
                if (ring1 != null)
                {
                    ring1.unequip();
                    inventory[inventorySafesaver] = ring1;
                }
                ring1 = item;
                break;

            case "ring2":
                if (ring2 != null)
                {
                    ring2.unequip();
                   inventory[inventorySafesaver] = ring2;
                }
                ring2 = item;
                break;

            case "ring3":
                if (ring3 != null)
                {
                    ring3.unequip();
                    inventory[inventorySafesaver] = ring3;
                }
                ring3 = item;
                break;

            case "ring4":
                if (ring4 != null)
                {
                    ring4.unequip();
                    inventory[inventorySafesaver] = ring4;
                }
                ring4 = item;
                break;

            case "ring5":
                if (ring5 != null)
                {
                    ring5.unequip();
                    inventory[inventorySafesaver] = ring5;
                }
                ring5 = item;
                break;

            case "ring6":
                if (ring6 != null)
                {
                    ring6.unequip();
                    inventory[inventorySafesaver] = ring6;
                }
                ring6 = item;
                break;

            case "ring7":
                if (ring7 != null)
                {
                    ring7.unequip();
                    inventory[inventorySafesaver] = ring7;
                }
                ring7 = item;
                break;

            case "ring8":
                if (ring8 != null)
                {
                    ring8.unequip();
                    inventory[inventorySafesaver] = ring8;
                }
                ring8 = item;
                break;
        }
        item.equip();
    }

    void unequip(string _slot)
    {

        if(!inventoryFull)
        {
            switch (_slot)
            {
                case "":

                    break;
            }
        }
    }

    public int attack()
    {
        int damage = Random.Range(0, strength);

        return damage;
    }

    public int attackDamage()
    {
        int dmg = weapon.rollDamage(weapon.dice, weapon.damageMod);

        return dmg;
    }

    public int defend()
    {

        int def = Random.Range(0, defense);
        return def;
    }

    public void takeDamage(int dmg)
    {
        health -= dmg - Random.Range( 1 , armour);
    }

    public void faint()
    {
        awake = false;
    }

    public void kill()
    {
        dead = true;
    }

    public bool struggle()
    {
        return false;
    }

    public void digest(int acidStrength)
    {
        //Check if passed out before digesting
        if(dead == true)
        {
            mass -= acidStrength;
            
            if(mass <= 0) //DIGESTED AWAY FOREVER...
            {
                digested = true;
            }
        }
        else if (awake == false)
        {
                health -= acidStrength;
            if(health <= 0) //THEY DIED....
            {
                kill();
            }
        }
        else if(stamina <= 0)
        {
            stamina = 0;
            faint();
        }
    }

    public void setCounters()
    {
        ui_name.text = charName;
        ui_health.text = health.ToString();
        ui_mana.text = magic.ToString();
        ui_stamina.text = stamina.ToString();
        ui_speed.text = speed.ToString();
        ui_def.text = defense.ToString();
        ui_agility.text = agility.ToString();
        ui_lust.text = lust.ToString();
        ui_sleep.text = ToString();
        ui_hunger.text = ToString();
        ui_xp.text = ToString();
        ui_level.text = ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
