using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrPepsiCola : Drink
{
    public DrPepsiCola() {
        pepsiPercent = 25;
        cokePercent = 25;
        rootBeerPercent = 50;
        cherryFlavouring = false;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        name = "Dr. Pepsi-Cola";
        description = "Make sure to get these percentages right. He’ll judge you if you don’t. \r\n" + "Your grandma wanted me to go into accounting, you know that? Nothing wrong with that, just wasn’t for me.I needed a bit of color in my life—something crazy every once in a while.No one ever wants craziness in their accounting. \n" + "- Aunt Dora";
    }
}
