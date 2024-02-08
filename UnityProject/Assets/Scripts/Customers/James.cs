using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class James : Customer {
    James() {
        name = "James";
        customerDrink = new Drink(0, 0, 100, true, false, false, 0);
    }
}
