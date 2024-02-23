using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gibson : Customer {
    public Gibson() {
        name = "Gibson";
        customerDrink = new EverythingCup(2);
    }
}
