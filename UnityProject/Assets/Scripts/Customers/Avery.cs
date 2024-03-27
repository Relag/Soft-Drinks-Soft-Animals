using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avery : Customer
{
    public Avery() {
        name = "Avery";
        customerDrink = new FieldsFavorite(2);
        customerSprite = Resources.Load<Sprite>("Art/Avery_Avian");
        SetDialogue();
    }

    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Hey there! Just came in for something simple. How about a Large Field’s Favorite?");
        dialogue[1].Add(1, "This looks great, thank you so much, have a good day.");
        dialogue[1].Add(0, "Oh no, this won’t do. Nevermind, it’s fine, I’ll take it. Thanks.");
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "Oh hello again, it’s really nice to see you, so nice seeing the youth hard at work! Can I have the Field’s Favorite please?");
        dialogue[2].Add(1, "Perfect, thanks so much, you’re really good at what you do. Take care!");
        dialogue[2].Add(0, "I don’t mean to impose but I don’t think this is the right drink, sorry!");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "3 days in a row? Might as well get used to us both. Call me Flutter if you like. That’s what my friends call me anyway.  How do you do it? I could never be in one place for a long time. DO you ever wish you could go somewhere and do something else? Ahhh, when am I not somewhere doing something else? Anyway, I’ll have my usual if you don’t mind.");
        dialogue[3].Add(1, "Mmm, that hits the spot. I’ll have to come here and bottle some up for my next trip. We’re going to the highest heights of the Himalayas!");
        dialogue[3].Add(0, "Hmm, not your best work. Is everything alright? You’re usually so sharp and diligent.");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "Hi, it’s me Flutter again! I’m so happy you remembered me. I’m here to pick up my usual please. My chicks have me going all over the place today, it’s hectic, but I wouldn’t change it for the world. Just taking a break is all.");
        dialogue[4].Add(1, "Mmm, maybe I should get some back for my chicks. My littlest one is turning 5, and she loves the colors. Oh, my change. Thank you. … Oh, sorry, I like looking through the coins I get to add to my collection. Last month, I found a rare Gaudens double eagle! Cool, right? Oh, I gotta go, bye!");
        dialogue[4].Add(0, "I wouldn’t even feed my kids this. I mean, the sugar, yes the sugar content is just through the roof! I think I’ll just empty this out over here, thanks.");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Hey! So guess what? It turns out that you had given me a silver dollar! A. SILVER. Dollar. DO you know how rare those things are?! I have been looking for something like that for YEARS, and you just gave it to me! I must pay you back for your kindness! Hey, how about some drinks, on me? It’s the least I could do for such a great find, my goodness. You go above and beyond!");
        dialogue[5].Add(1, "You are just the best! I will definitely bring my chicks here after school sometimes. I want to cherish this drink for a while here, it will be my last before my plane takes off and I’ll be sky high! Thanks for being the absolute best, I got a new favorite drink, a rare coin and a good friend! See you next week!");
        dialogue[5].Add(0, "Not the best note to leave on but thank you, you tried your best. I’ll be back in a week to see you for more.");

    }
}
