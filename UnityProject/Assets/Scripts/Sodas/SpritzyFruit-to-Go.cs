using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritzyFruit : Drink
{
    public SpritzyFruit(int size = 0)
    {
        HoneyFizz = 100;
        RippleCola = 0;
        BirchBeer = 0;
        cherryFlavouring = false;
        strawberryFlavouring = true;
        grapeFlavouring = false;
        name = "Spritzy Fruit-to-go";
        description = "Lots of sugar. Perfect for studying, unless you spill it on your notes.\n\nThis was always your mom�s favorite.\n�Aunt Dora";
        SetSize(size);
    }
}
