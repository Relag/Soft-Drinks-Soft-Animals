using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{


   public string[] Benjamin = new string[]
   {
       "Howdy! You must be Dora’s kid—you look just like her. I’m Benjamin Bearenthal, but you can call me Benny. Oh, I guess you’ll be needing my order! Dora always remembered it...Just a medium plain soda for me.",
       "Just how I like it. Well, I hope you like it here in the city. Come on down to the post office if you need a friendly face.",
       "Hmm...maybe you just need some practice, huh? You’ll get it.",
       "Howdy! Medium plain soda for me, we don’t change around here. I remember when Dora started this place...",
       "...and Alan snorted grape soda right out his nose, the poor gator...was I going on again? Thank you.",
       "...and Alan...wait, what’d you give me? That’s not right. Are you one of those youngins who loves playing jokes on their elders? I’ll let it go. I was young once, too.",
       "Howdy! Whew, it’s always a day when the candy stamps overflow. You got the usual?",
       "That hits the spot. Can you believe those youngins want me to retire? What would they do without me?",
       "Well, uh...they can’t all be winners, can they? Thanks for trying, kiddo. At least you don’t keep telling me I ought to retire.",
       "Howdy. Just the usual.",
       "Thanks, kiddo. At least the soda stays the same. You don’t see anyone trying to leave plain soda behind.",
       "It’s fine, kiddo...no respect, and now no soda. Why do I even try?",
       "Howdy! The usual?",
       "You know, you’ve always got my order, kiddo. Helping me out. Maybe that’s all those yougins are trying to do—help an old man out. Maybe once I retire...I’ll have more time to try all these newfangled sodas, huh?",
       "Those soda machines broken, kiddo? Haha, it’s all right. We all make mistakes—but we’ve got time. Maybe that’s all those youngins were trying to do—give me more time. Well, I reckon that’s an idea worth considering."
   };

    public string[] Gibson = new string[]
        {
            "Huh? Oh. Uh—the one with everything. Large.",
            "Oh. Right. Drink. This is good, thank you.",
            "Um...aack! This appears to be...not what I ordered. JJ, did I order it wrong again? I probably did. Darn. This paper...",
            "What, I’m in the middle of a sentence—oh, we’re here. Large Everything Cup, please, thank you.",
            "The implications of stuffed animal life being legitimized only through the complete bodily transformation into flesh and blood, thus erasing the identity of “stuffed” entirely, constitute, frankly, an existential nightmare, in which—oh. Thank you. Thank you, JJ.",
            "—thus, the question becomes: how does one define reality? Does a sentient stuffed lifeform experience reality, or does reality only begin at the moment of transformation to organic? If the sentient stuffed lifeform does not experience reality, in what way are they sentient; what do they experience? Oh. Um. This is...unexpected. I didn’t order this. May I still drink it? I don’t want to keep standing in line.",
            "Hello, sorry—you know which one. Has it really been twenty-one years, JJ?",
            "I know I’ve been...busy. But—once I’ve got my doctorate, there’s a lot of things I need to—oh, thank you. You’re my best friend, JJ, you know that?",
            "I know I’ve been...busy. But—once I’ve got my doctorate, there’s a lot of things I need to—oh. Hmm. This is...not the right drink. You’re my best friend, JJ, you know that? Even if you take me to soda bars that get my order wrong.",
            "I can’t, JJ. I barely have time to come to the soda bar. It’s due in...6 hours, 13 minutes. Also, why would you want to take me on a walk, look at me. Um—hello, you know which one, right?",
            "JJ, wait a second. Wait, don’t get upset—thank you for the drink. I guess.",
            "JJ, wait a second. Wait, don’t get upset—and the drink’s wrong, too. Argh!",
            "Hello, I’d like to order the...this feels weird. You know which one.",
            "Do you want to try mine, JJ? Is that, um—proper date behavior? I am...messing this up so badly already. But—I like being here with you.",
            "Do you want mine, JJ? They got it wrong, but I’ve heard sharing is, um—proper date behavior? I am...messing this up as badly as they messed up this drink. But—I like being here with you."
        };

    public string[] James = new string[]
    {
        "Hey! I heard there was a new person in town. I’m James—you can call me JJ—and that was Gibson. Don’t mind him, his thesis is draining all the stuffing out of him. He’s usually more—well, actually, he’s pretty much always like this. Can I get a small grape root beer?",
        "Thanks! Come on, Gib, let’s sit down before you fall over.",
        "Uh, that is...not how I remembered it tasting. Oh, well. Still good. Gib, let’s sit down before you fall over.",
        "Hey, could I get a grape soda, please? And I’ll cover Gibson.",
        "Thanks so much. Gibson, I don’t have any clue what you’re saying, but it sounds smart? Like always. You can take a minute to breathe, you know.",
        "Uh...sure, okay, I’ll take it. Close enough. Gibson, I don’t have any clue what you’re saying, but it sounds smart? Like always. You can take a minute to breathe, you know.",
        "Hey, same as always, please? Yes, Gib, it’s been exactly twenty-one years since I stole your can out of the sandbox.",
        "Thank you, that tastes awesome. Hey Gibson, we should celebrate. Would you maybe want to...uh, you know, never mind.",
        "Um...thanks. It’s, uh—not what I expected, but sometimes you gotta change it up, I guess? Hey Gibson, we should celebrate our sandbox day. Would you maybe want to...uh, you know, never mind.",
        "Don’t get upset? I never ask you for anything, except for this! One walk in the park. We just finished landscaping it, and I know you’d like it. I mean, I know I’m the outdoors guy and you’re, uh...not, but I swear, it’s really nice, and it would only take a minute, I just—hey there, same as always. Please.",
        "Thanks. All right, whatever, Gibson. Go get another doctorate before you have time for me.",
        "And this isn’t even the right—whatever. You can mess up the soda. Gibson can go get another doctorate before he makes time for me. I don’t care.",
        "Same as always, please! I’m sorry about yesterday. It’s, uh...a better day now.",
        "I didn’t think we’d get here, you know? I’ve had a crush on this guy for ages. And I never thought—well, it’s better than what I thought. Being with him. It’s the best thing that’s ever happened to me—no offense to your grape sodas!",
        "Aw, man, this isn’t—you know what? It’s fine. It’s crazy that Gib and I are on a date in the first place. I’ve had a crush on this guy for ages. And I never thought—well, it’s better than what I thought. Being with him. It’s the best thing that’s ever happened to me—full offense to your grape sodas!"
    };

    public string[] Rosco = new string[]
    {
        "Hello there. Uh, I think I will go with the Medium Spritzy Fruit-to-Go if you don’t mind. Cool?",
        "Thanks.",
        "Uh, not exactly what I wanted, but, it’s okay…I guess.",
        "Oh hey, it’s you again. Cool. Uh, how are you? I guess? Uh, I’ll take the Spritzy Fruit-to-Go, just to make it easy. It was…really good, last time.",
        "That really hit the spot. Thank you so much, I really like these flavors together.",
        "Oh, uh…that’s alright. Mistakes happen. Still being in school, I know that all too well. You’ll get the hang of it…I guess.",
        "Hey. Wow, you work here every day? That’s dedication. Maybe one day when I finish my studies of electrical engineering, I can come here. Although there may be too many people for me…heheh. Anyways, do you remember my usual? It’s okay, if you don’t, I guess, yeah. I’d like that.",
        "You…remembered. That’s nice. Mmmm, even the drinks at my school are nothing compared to this. Even with all the people, maybe it may be worthwhile coming here more often.",
        "I guess you didn’t remember then…that’s fine. It happens to the best of us. I remember one time I forgot my sister’s birthday and gave her a makeshift gift out of gears and wires I found being thrown away. She forgave me though…eventually…",
        "Hello. How’s it going? Working hard today? I hope it’s not too busy, I don’t know if I could ever manage being here for too long. The bright lights kind of hurt my eyes, but here it’s not so bad. Oh yeah, I’ll have my usual again, but it’s not for me. It’ll be for my brother this time.",
        "Mmmm just as great as ever. I cannot wait to have my brother try this. Maybe he could share with the rest of us. My mom and dad don’t like fizzy drinks often, but I think this may just change all of their minds. You’re like, a drink scientist.",
        "Yeah, no, still not it…I’m guessing you forgot. I’m usually pretty forgettable so I understand. I’ll still take it though, I’m sure, someone will take it off my hands…maybe.",
        "Quite a busy time. Glad it’s the end of the week, I hope you’re doing well. Had a big math test today but I am so glad for it to be over! So, I’m here to celebrate with a good drink…or cheer myself up, preemptively anyway. I’ll find out either way in a few days. At least now I can relax and stay home for a few days. Catch on my sleep. But for now, drink time.",
        "Now that I think about it, I think these must be the best drinks in the city. You get them right and tasty. I think I’ll keep on coming here.",
        "This isn’t what I wanted…I’m sorry. I’m not mad, just disappointed."
    };

    public string[] Felix = new string[]
        {
            "Yes, hello. Sorry one sec! *phone chatter* Sorry, very important meeting. Let me have the Small Dr. Cola please.",
            "Ahh thank you. Here, exact change, as calculated.",
            "Oh uh, perhaps it’s just the ratios that are off. Even Pythagoras got some initial theories wrong, right?",
            "Oh hey, you served me approximately 23 hours, 49 minutes and 37 seconds ago! What are the chances? Exactly 67.8%, of course. I shall have the Dr. Cola again.",
            "Excellent, this was certainly created by someone who understands the natural order of substances. Well done.",
            "Well, I must say, it isn’t the worst thing I’ve seen. Perhaps you should take note of my students, now while kids can surprise you, kids can also disappoint you.",
            "Oh, it’s you, good! What is the probability that I will be able to get a *insert drink name here* in approximately 1 minute and 37 seconds? I lost track of all time while reading Orwell’s ‘Down and Out In Paris and London’! Talk about one of the best memoirs of all time. I don’t mean to brag but I too was close to becoming a best-selling memoir author. Ahhh, 1058 pages of sheer me…oh, sorry, I’m doing it again.",
            "Wow, a new personal best! At this rate, you will be positively swimming in those soda streams! Maybe perhaps I should write a dissertation on the efforts of soda crafting! Think about it, you’d make a really great muse.",
            "You…certainly tried. But not only is this combination and ratio off, I am also now 3 minutes and 45 seconds later than I needed to be. Euler would be so disappointed in me.",
            "Good day to you! Have you read the morning paper? Everyone is talking about your shop, I must say you’re a real chemist in the kitchen. Uhh, one of my students, Rosco, the one with the unorderly appearance and…alternative demeanor, comes here often I see. He showed it to our class. A freshly mixed drink is exactly what I need to celebrate your honor, I will take what I usually have.",
            "Cheers to your success! May your recipes remain calculated and true!",
            "Maybe they should have reconsidered retouching some statements! Ahem, oh, a new recipe by chance? Good to know…",
            "Here you are, my soda barista. How are you doing on this lovely day? It’s test day, my favorite day of the week! Always refreshing seeing students’ works. You know I tried having a discussion with my colleagues on the 90° angles of the new ceilings of our staff building, turns out it was all right, but kept going in tangents if you catch my drift. Say, how about a drink to bring the spirits up and keep the old noggin sharp, hmm?",
            "If you were a student in my class, I would give you extra extra EXTRA credit! The flavors, the aroma, it reminds me of my rainy days while inside reading Chekhov’s ‘Cherry Orchard’. Ah! Such a delight. SHould ever a colleague of mine require a drink, I’ll know exactly where to send them!",
            "Just as chemistry switched from Dalton to Rutherford, so too maybe I must switch gears. It is…adequate, and yet, mildly discouraging all the same."
        };

    public string[] Candi = new string[]
        {
            "Hi there! How’s it going? Good, good! My day’s been great. I will have the Medium Cheery Float to go please. I’m in a little bit of a rush! Thank you!",
            "Great! Thanks, be sure to follow me!",
            "Uhhh…hehe, no this is great. I love it, don’t sweat it…too much.",
            "Yoohoo! I’m back! Just got done with such an intense workout, so, need to hydrate! Whatcha got for me? Hmmm, I’ll just take the Cheery Float again, that should be easy for you right?!",
            "Ouuu you ARE good! Here, let’s take a selfie! I’ll caption you as the ‘star barista’ of the town, how does that sound? Great, toodles!",
            "Hey, don’t even worry about it, nothing comes easy to everyone right? It’s fine, really. I promise!",
            "Hey! It’s me, your favorite customer! I just had to come back, I followed you on all of your socials by the way, isn’t that fun! You haven’t followed me back yet though…let’s change that when you have time yeah? How about this, how about you make it up to me with my fave? I still want the follows though…hehe!",
            "You remembered! O-M-G, you are the absolute best! You know, I see you around here often, and you’re quick too! What’s your secret? You have to let me in on it, I can share with you all my secrets in return. Well, only the juicy stuff.",
            "Oh, that’s quite alright, I’ll take the follows only, thanks…",
            "Hello hello! Thank you for the follows and your support, always appreciated! Did you see my latest video? Can you believe I did 20 reps in 13 seconds?! That has to be like a new record or something. I have to keep at it, it takes a lot to look and feel great and I don’t wanna slow down any time soon. Say, if you whip me up one of my favorites, maybe I could give you some screen time on my profiles, shout you out a bit you know? I’ll even tag you in it!",
            "Record time! You’re really fast! And 30 drinks in an hour?! Your reps in the gym must be insane. Wait, NO! Don’t tell me you’re just that naturally talented?! I’m totes jelly!",
            "The one drink I’m REALLY gonna have to work off…",
            "Hope business is booming! Can you believe our video got 400k views? People are all the rage about your drinks, and it’s all thanks to me! Say, I could try and hook you up with a sponsorship deal at the gym I frequently go to? They love me, I practically live there! You should come with! Not that you need it but we could totally be like workout BFFS! Sounds great right?! Let’s get some drinks out to celebrate!",
            "Cheers to new friendships and gym workouts and sponsorships!",
            "This…I’ll talk to the owner, maybe give him a small sample size."
        };

    public string[] Avery = new string[]
    {
        "Hey there! Just came in for something simple. How about a Large Field’s Favorite?",
        "This looks great, thank you so much, have a good day.",
        "Oh no, this won’t do. Nevermind, it’s fine, I’ll take it. Thanks.",
        "Oh hello again, it’s really nice to see you, so nice seeing the youth hard at work! Can I have the Field’s Favorite please?",
        "Perfect, thanks so much, you’re really good at what you do. Take care!",
        "I don’t mean to impose but I don’t think this is the right drink, sorry!",
        "3 days in a row? Might as well get used to us both. Call me Flutter if you like. That’s what my friends call me anyway.  How do you do it? I could never be in one place for a long time. DO you ever wish you could go somewhere and do something else? Ahhh, when am I not somewhere doing something else? Anyway, I’ll have my usual if you don’t mind.",
        "Mmm, that hits the spot. I’ll have to come here and bottle some up for my next trip. We’re going to the highest heights of the Himalayas!",
        "Hmm, not your best work. Is everything alright? You’re usually so sharp and diligent.",
        "Hi, it’s me Flutter again! I’m so happy you remembered me. I’m here to pick up my usual please. My chicks have me going all over the place today, it’s hectic, but I wouldn’t change it for the world. Just taking a break is all.",
        "Mmm, maybe I should get some back for my chicks. My littlest one is turning 5, and she loves the colors. Oh, my change. Thank you. … Oh, sorry, I like looking through the coins I get to add to my collection. Last month, I found a rare Gaudens double eagle! Cool, right? Oh, I gotta go, bye!",
        "I wouldn’t even feed my kids this. I mean, the sugar, yes the sugar content is just through the roof! I think I’ll just empty this out over here, thanks.",
        "Hey! So guess what? It turns out that you had given me a silver dollar! A. SILVER. Dollar. DO you know how rare those things are?! I have been looking for something like that for YEARS, and you just gave it to me! I must pay you back for your kindness! Hey, how about some drinks, on me? It’s the least I could do for such a great find, my goodness. You go above and beyond!",
        "You are just the best! I will definitely bring my chicks here after school sometimes. I want to cherish this drink for a while here, it will be my last before my plane takes off and I’ll be sky high! Thanks for being the absolute best, I got a new favorite drink, a rare coin and a good friend! See you next week!",
        "Not the best note to leave on but thank you, you tried your best. I’ll be back in a week to see you for more."
    };



}
