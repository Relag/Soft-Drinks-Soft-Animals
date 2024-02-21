using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeryFloat : Drink
{
    public CheeryFloat(int size = 0)
    {
        HoneyFizz = 25;
        RippleCola = 75;
        BirchBeer = 0;
        cherryFlavouring = true;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        name = "Cheery Float";
        description = "Guaranteed to bring a smile on the go.\nAfter me and Alan moved to Bermodo City, it was harder and harder to keep in touch with your mom. We were all so busy. \nI don’t have many regrets about this life, but that’s one of them.\n—Aunt Dora";
        SetSize(size);
    }
}
