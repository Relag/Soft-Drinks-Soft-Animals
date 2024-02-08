using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrCola : Drink
{
    public DrCola(int size) {
        HoneyFizz = 25;
        RippleCola = 25;
        ButtonBirchBeer = 50;
        cherryFlavouring = false;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        name = "Dr. Cola";
        description = "Make sure to get these percentages right. He’ll judge you if you don’t. \r\n" + "Your grandma wanted me to go into accounting, you know that? Nothing wrong with that, just wasn’t for me.I needed a bit of color in my life—something crazy every once in a while.No one ever wants craziness in their accounting. \n" + "- Aunt Dora";
        SetSize(size);
    }
}
