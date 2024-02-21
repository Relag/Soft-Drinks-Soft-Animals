using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverythingCup : Drink
{
    public EverythingCup(int size = 0)
    {
        HoneyFizz = 25;
        RippleCola = 25;
        BirchBeer = 50;
        cherryFlavouring = true;
        strawberryFlavouring = true;
        grapeFlavouring = true;
        name = "Everything Cup";
        description = "Need quite a digestive system to process this one.\nYou and your mom came to visit once, when you were little.You probably don’t even remember it. It was all of us in this little place I built for our family. \nYour mom said absolutely no sugar or caffeine.But that’s no way to live a life, is it ?\nI gave you this drink, and you LOVED it.You bounced off the walls and wouldn’t stop smiling.We all couldn’t stop smiling—even your mom.It was one of the happiest days of my life.\nI hope it still makes you smile.\n—Aunt Dora";
        SetSize(size);
    }
}
