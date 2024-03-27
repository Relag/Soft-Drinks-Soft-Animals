using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candi : Customer
{
    public Candi() {
        name = "Candi";
        customerDrink = new SpritzyFruit(1);
        customerSprite = Resources.Load<Sprite>("Art/Candi_Cat");
        SetDialogue();
    }
    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Hi there! How’s it going? Good, good! My day’s been great. I will have the Medium Spritzy Fruit to go please. I’m in a little bit of a rush! Thank you!");
        dialogue[1].Add(1, "Great! Thanks, be sure to follow me!");
        dialogue[1].Add(0, "Uhhh…hehe, no this is great. I love it, don’t sweat it…too much.");
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "Yoohoo! I’m back! Just got done with such an intense workout, so, need to hydrate! Whatcha got for me? Hmmm, I’ll just take the Cheery Float again, that should be easy for you right?!");
        dialogue[2].Add(1, "Ouuu you ARE good! Here, let’s take a selfie! I’ll caption you as the ‘star barista’ of the town, how does that sound? Great, toodles!");
        dialogue[2].Add(0, "Hey, don’t even worry about it, nothing comes easy to everyone right? It’s fine, really. I promise!");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "Hey! It’s me, your favorite customer! I just had to come back, I followed you on all of your socials by the way, isn’t that fun! You haven’t followed me back yet though…let’s change that when you have time yeah? How about this, how about you make it up to me with my fave? I still want the follows though…hehe!");
        dialogue[3].Add(1, "You remembered! O-M-G, you are the absolute best! You know, I see you around here often, and you’re quick too! What’s your secret? You have to let me in on it, I can share with you all my secrets in return. Well, only the juicy stuff.");
        dialogue[3].Add(0, "Oh, that’s quite alright, I’ll take the follows only, thanks…");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "Hello hello! Thank you for the follows and your support, always appreciated! Did you see my latest video? Can you believe I did 20 reps in 13 seconds?! That has to be like a new record or something. I have to keep at it, it takes a lot to look and feel great and I don’t wanna slow down any time soon. Say, if you whip me up one of my favorites, maybe I could give you some screen time on my profiles, shout you out a bit you know? I’ll even tag you in it!");
        dialogue[4].Add(1, "Record time! You’re really fast! And 30 drinks in an hour?! Your reps in the gym must be insane. Wait, NO! Don’t tell me you’re just that naturally talented?! I’m totes jelly!");
        dialogue[4].Add(0, "The one drink I’m REALLY gonna have to work off…");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Hope business is booming! Can you believe our video got 400k views? People are all the rage about your drinks, and it’s all thanks to me! Say, I could try and hook you up with a sponsorship deal at the gym I frequently go to? They love me, I practically live there! You should come with! Not that you need it but we could totally be like workout BFFS! Sounds great right?! Let’s get some drinks out to celebrate!");
        dialogue[5].Add(1, "Cheers to new friendships and gym workouts and sponsorships!");
        dialogue[5].Add(0, "This…I’ll talk to the owner, maybe give him a small sample size.");
    }
}
