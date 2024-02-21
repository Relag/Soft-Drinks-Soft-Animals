using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldsFavorite: Drink
{
    public FieldsFavorite(int size = 0)
    {
        HoneyFizz = 0;
        RippleCola = 50;
        BirchBeer = 50;
        cherryFlavouring = false;
        strawberryFlavouring = true;
        grapeFlavouring = true;
        name = "Fields' Favorite";
        description = "For those who love adventure, but will always come right on home.  I ever tell you about how I met Alan? It was right here in this soda shop. I had to choose his drink for him. He’d seen me behind the bar and forgotten what to say! (At least that’s what he tells me. I think maybe he was just daydreaming.)\nAnyway, I made him this drink, and...well, let’s just say it was probably the wrong choice. He spat it clean out! But it’s fine—he was the choice that mattered, in the end. And I chose right that time.\n—Aunt Dora";
        SetSize(size);
    }
}
