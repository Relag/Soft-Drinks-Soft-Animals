using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer { 

    //A dictionary of dictionaries. Stores day number as key to nested dictionaries, bool true for correct order, false for incorrect order, undefined for intro dialogue. 
    protected Dictionary<int, Dictionary <bool, string>> dialogue = new Dictionary<int, Dictionary<bool, string>>();
    protected Drink customerDrink { get; set; }
    protected string name { get; set; }
    protected Sprite customerSprite { set; get; }

    public string GetDialogue (int day, bool response) {
        string speech;
        Dictionary<bool, string> whatDay = new Dictionary<bool, string>();
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
}
