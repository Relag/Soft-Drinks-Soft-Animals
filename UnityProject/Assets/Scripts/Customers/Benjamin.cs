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
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "Howdy! Medium plain soda for me, we don’t change around here. I remember when Dora started this place...");
        dialogue[2].Add(1, "...and Alan snorted grape soda right out his nose, the poor gator...was I going on again? Thank you.");
        dialogue[2].Add(0, "...and Alan...wait, what’d you give me? That’s not right. Are you one of those youngins who loves playing jokes on their elders? I’ll let it go. I was young once, too.");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "Howdy! Whew, it’s always a day when the candy stamps overflow. You got the usual?");
        dialogue[3].Add(1, "That hits the spot. Can you believe those youngins want me to retire? What would they do without me?");
        dialogue[3].Add(0, "Well, uh...they can’t all be winners, can they? Thanks for trying, kiddo. At least you don’t keep telling me I ought to retire.");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "Howdy. Just the usual.");
        dialogue[4].Add(1, "Thanks, kiddo. At least the soda stays the same. You don’t see anyone trying to leave plain soda behind.");
        dialogue[4].Add(0, "It’s fine, kiddo...no respect, and now no soda. Why do I even try?");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Howdy! The usual?");
        dialogue[5].Add(1, "You know, you’ve always got my order, kiddo.Helping me out.Maybe that’s all those yougins are trying to do—help an old man out. Maybe once I retire...I’ll have more time to try all these newfangled sodas, huh?");
        dialogue[5].Add(0, "Those soda machines broken, kiddo? Haha, it’s all right. We all make mistakes—but we’ve got time. Maybe that’s all those youngins were trying to do—give me more time. Well, I reckon that’s an idea worth considering.");
    }
}
