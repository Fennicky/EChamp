using UnityEngine;
using System.Collections;

public class Whip : Item {

    

    public Whip(string _name, string _slot, int _invSlot)
    {
        name = _name;
        slot = _slot;
        invSlot = _invSlot;
        description = "Kinky yet deadly.";
        damageMod = 10;
        speed = 8;
        dice = 3;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
