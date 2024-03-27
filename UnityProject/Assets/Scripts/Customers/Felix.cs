using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felix : Customer
{
    public Felix() {
        name = "Felix";
        customerDrink = new DrCola(0);
        customerSprite = Resources.Load<Sprite>("Art/Felix_Fisher");
        SetDialogue();
    }

    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Yes, hello. Sorry one sec! *phone chatter* Sorry, very important meeting. Let me have the Small Dr. Cola please.");
        dialogue[1].Add(1, "Ahh thank you. Here, exact change, as calculated.");
        dialogue[1].Add(0, "Oh uh, perhaps it’s just the ratios that are off.Even Pythagoras got some initial theories wrong, right ? ");
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "Oh hey, you served me approximately 23 hours, 49 minutes and 37 seconds ago! What are the chances? Exactly 67.8%, of course. I shall have the Dr. Cola again.");
        dialogue[2].Add(1, "Excellent, this was certainly created by someone who understands the natural order of substances. Well done.");
        dialogue[2].Add(0, "Well, I must say, it isn’t the worst thing I’ve seen. Perhaps you should take note of my students, now while kids can surprise you, kids can also disappoint you.");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "Oh, it’s you, good! What is the probability that I will be able to get a *insert drink name here* in approximately 1 minute and 37 seconds? I lost track of all time while reading Orwell’s ‘Down and Out In Paris and London’! Talk about one of the best memoirs of all time. I don’t mean to brag but I too was close to becoming a best-selling memoir author. Ahhh, 1058 pages of sheer me…oh, sorry, I’m doing it again.");
        dialogue[3].Add(1, "Wow, a new personal best! At this rate, you will be positively swimming in those soda streams! Maybe perhaps I should write a dissertation on the efforts of soda crafting! Think about it, you’d make a really great muse.");
        dialogue[3].Add(0, "You…certainly tried.But not only is this combination and ratio off, I am also now 3 minutes and 45 seconds later than I needed to be.Euler would be so disappointed in me.");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "Good day to you! Have you read the morning paper? Everyone is talking about your shop, I must say you’re a real chemist in the kitchen. Uhh, one of my students, Rosco, the one with the unorderly appearance and…alternative demeanor, comes here often I see. He showed it to our class. A freshly mixed drink is exactly what I need to celebrate your honor, I will take what I usually have.");
        dialogue[4].Add(1, "Cheers to your success! May your recipes remain calculated and true!");
        dialogue[4].Add(0, "Maybe they should have reconsidered retouching some statements! Ahem, oh, a new recipe by chance? Good to know…");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Here you are, my soda barista. How are you doing on this lovely day? It’s test day, my favorite day of the week! Always refreshing seeing students’ works. You know I tried having a discussion with my colleagues on the 90° angles of the new ceilings of our staff building, turns out it was all right, but kept going in tangents if you catch my drift. Say, how about a drink to bring the spirits up and keep the old noggin sharp, hmm?");
        dialogue[5].Add(1, "If you were a student in my class, I would give you extra extra EXTRA credit! The flavors, the aroma, it reminds me of my rainy days while inside reading Chekhov’s ‘Cherry Orchard’. Ah! Such a delight. SHould ever a colleague of mine require a drink, I’ll know exactly where to send them!");
        dialogue[5].Add(0, "Just as chemistry switched from Dalton to Rutherford, so too maybe I must switch gears. It is…adequate, and yet, mildly discouraging all the same.");
    }
}
