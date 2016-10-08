using UnityEngine;
using System.Collections;

public class Potion : Item {

    Player p = GameObject.Find("Player").GetComponent<Player>();

	// Use this for initialization
	void Start () {
	
	}

    public new void effect()
    {
        p.heal(15);
        p.genMana(15);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
