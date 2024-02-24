using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benjamin : Customer
{
    public Benjamin() {
        customerDrink = new PlainSoda(1);
        name = "Benjamin";
        customerSprite = Resources.Load<Sprite>("Art/bear_ben");
        SetDialogue();
    }

    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Howdy! You must be Dora’s kid—you look just like her. I’m Benjamin Bearenthal, but you can call me Benny. Oh, I guess you’ll be needing my order! Dora always remembered it...Just a medium plain soda for me.");
        dialogue[1].Add(1, "Just how I like it. Well, I hope you like it here in the city. Come on down to the post office if you need a friendly face.");
        dialogue[1].Add(0, "Hmm...maybe you just need some practice, huh ? You’ll get it.");
    }
}
