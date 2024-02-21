using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlainSoda : Drink
{
    public PlainSoda(int size = 0)
    {
        HoneyFizz = 0;
        RippleCola = 100;
        BirchBeer = 0;
        cherryFlavouring = false;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        name = "Plain Soda";
        description = "Tell Bearenthal to try something new once in a while, would you?\n\nStarted this shop when Bermodo City wasn’t even on the map.Now it’s yours. The people, too. Take good care of them.\n—Aunt Dora";
        SetSize(size);
    }
}