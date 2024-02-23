using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rosco : Customer
{
    public Rosco() {
        name = "Rosco";
        customerDrink = new SpritzyFruit(1);
    }
}
