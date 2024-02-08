using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felix : Customer
{
    Felix() {
        name = "Felix";
        customerDrink = new DrCola(0);
    }
}
