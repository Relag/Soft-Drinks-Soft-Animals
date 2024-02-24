using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Customer { 

    //A dictionary of dictionaries. Stores day number as key to nested dictionaries, bool true for correct order, false for incorrect order, undefined (NULL) for intro dialogue. 
    protected Dictionary<int, Dictionary <int, string>> dialogue = new Dictionary<int, Dictionary<int, string>>();
    protected Drink customerDrink { get; set; }
    protected string name { get; set; }
    protected Sprite customerSprite { set; get; }

    public string GetDialogue (int day, int response = 2) {
        string speech;
        Dictionary<int, string> whatDay = new Dictionary<int, string>();
        whatDay = dialogue[day];
        speech = whatDay[response];
        return speech;
    }

    public Drink GetDrink() {
        return customerDrink;
    }

    public Sprite GetSprite() {
        return customerSprite;
    }

    protected abstract void SetDialogue();
}
