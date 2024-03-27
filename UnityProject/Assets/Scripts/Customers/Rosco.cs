using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rosco : Customer
{
    public Rosco() {
        name = "Rosco";
        customerDrink = new SpritzyFruit(1);
        customerSprite = Resources.Load<Sprite>("Art/Rosco_Raccoon");
        SetDialogue();
    }

    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Hello there. Uh, I think I will go with the Medium Spritzy Fruit-to-Go if you don’t mind. Cool?");
        dialogue[1].Add(1, "Thanks.");
        dialogue[1].Add(0, "Uh, not exactly what I wanted, but, it’s okay…I guess.");
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "Oh hey, it’s you again. Cool. Uh, how are you? I guess? Uh, I’ll take the Spritzy Fruit-to-Go, just to make it easy. It was…really good, last time.");
        dialogue[2].Add(1, "That really hit the spot. Thank you so much, I really like these flavors together.");
        dialogue[2].Add(0, "Oh, uh…that’s alright. Mistakes happen. Still being in school, I know that all too well. You’ll get the hang of it…I guess.");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "Hey. Wow, you work here every day? That’s dedication. Maybe one day when I finish my studies of electrical engineering, I can come here. Although there may be too many people for me…heheh. Anyways, do you remember my usual? It’s okay, if you don’t, I guess, yeah. I’d like that.");
        dialogue[3].Add(1, "You…remembered. That’s nice. Mmmm, even the drinks at my school are nothing compared to this. Even with all the people, maybe it may be worthwhile coming here more often.");
        dialogue[3].Add(0, "I guess you didn’t remember then…that’s fine. It happens to the best of us. I remember one time I forgot my sister’s birthday and gave her a makeshift gift out of gears and wires I found being thrown away. She forgave me though…eventually…");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "Hello. How’s it going? Working hard today? I hope it’s not too busy, I don’t know if I could ever manage being here for too long. The bright lights kind of hurt my eyes, but here it’s not so bad. Oh yeah, I’ll have my usual again, but it’s not for me. It’ll be for my brother this time.");
        dialogue[4].Add(1, "Mmmm just as great as ever. I cannot wait to have my brother try this. Maybe he could share with the rest of us. My mom and dad don’t like fizzy drinks often, but I think this may just change all of their minds. You’re like, a drink scientist.");
        dialogue[4].Add(0, "Yeah, no, still not it…I’m guessing you forgot.I’m usually pretty forgettable so I understand.I’ll still take it though, I’m sure, someone will take it off my hands…maybe.");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Quite a busy time. Glad it’s the end of the week, I hope you’re doing well. Had a big math test today but I am so glad for it to be over! So, I’m here to celebrate with a good drink…or cheer myself up, preemptively anyway. I’ll find out either way in a few days. At least now I can relax and stay home for a few days. Catch on my sleep. But for now, drink time.");
        dialogue[5].Add(1, "Now that I think about it, I think these must be the best drinks in the city. You get them right and tasty. I think I’ll keep on coming here.");
        dialogue[5].Add(0, "This isn’t what I wanted…I’m sorry. I’m not mad, just disappointed.");
    }
}
