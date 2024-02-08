using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer { 

    //A dictionary of dictionaries. Stores day number as key to nested dictionaries, bool true for correct order, false for incorrect order, undefined for intro dialogue. 
    public Dictionary<int, Dictionary <bool, string>> dialogue = new Dictionary<int, Dictionary<bool, string>>();
    Drink customerDrink = new Drink();
    string name;
    Sprite customerSprite;
}
