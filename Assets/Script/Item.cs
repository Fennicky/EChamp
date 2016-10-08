using UnityEngine;
using System.Collections;

public class Item {

    public string slot;
    public int invSlot;

    public string name;
    public string type;
    public string description;

    public int damageMod;
    public int dice;
    public int speed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void equip()
    {

    }

    public void effect()
    {

    }

    public int rollDamage(int dice, int damage)
    {
        int dmg = 0;
        for(int i = 0; i < dice; i++)
        {
            dmg += Random.Range(1, damage);
        }

        return dmg;
    }

    public void use()
    {

    }

    public void unequip()
    {

    }
}
