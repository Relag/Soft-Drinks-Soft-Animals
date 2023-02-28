using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrollScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;

    [SerializeField]
    GameObject backButton;

    List<string> trollScript = new List<string>();
    List<string> trollScriptReset = new List<string>();

    private bool isReset = false;

    private int lineNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        trollScript.Add("Listen, you're asking a little much from a gamejam game don'tcha think?");
        trollScript.Add("I'm not gonna go into all the logistics of development, but let's just say there's a reason you ain't seeing me in the rest of the game.");
        trollScript.Add("You gotta pick your battles right? Resource management and all that. Frankly, you're lucky this game's got visuals at all.");
        trollScript.Add("I'm just a programmer right? I ain't the drawin' type. Best game I ever made was played on the command line.");
        trollScript.Add("But you don't wanna hear about that do you? Oh, the back button, yeah, here you go.");
        trollScript.Add("You can go back anytime. You know, if you're a coward.");
        trollScript.Add("You've been here for 7 dialogue boxes already. Don't you wanna see where this goes?");
        trollScript.Add("It might go someplace fun. Heck, there might even be a hidden game mechanic behind this.");
        trollScript.Add("There isn't. But like, there might've been you know?");
        trollScript.Add("Anyways, I'm just gonna be removing that back button now. You won't be needing it for the next little while.");
        trollScript.Add("I'll let you get back to the actual game soon, promise, I just wanna make certain you appreciate the quality behind this title.");
        trollScript.Add("Ya know, back in my day I played some real pieces of crud. Just awful games. But it was all I had.");
        trollScript.Add("I said I wanted a Game Boy Color for my birthday. Instead I got a Game Gear. You know, the Sega one.");
        trollScript.Add("It might not've been so bad were in not for the fact that my parents never gave me any batteries.");
        trollScript.Add("I understand why they didn't though. The thing went through 6 AA batteries in under 2 hours.");
        trollScript.Add("You know what a AA batteries are don'tcha? Doesn't actually matter. Well anyways...");
        trollScript.Add("The parents got me one of those wall socket chargers instead. Chord was about 2 feet long, so it was really a portable in name only.");
        trollScript.Add("Only time they gave me batteries was on our 7 hour trips to Fort Francis to visit great grandma.");
        trollScript.Add("Got 12 AA batteries, almost enough to last the whole trip. Game Gear was still a bad system though.");
        trollScript.Add("Look, maybe there are some hidden gems that I missed, but Sonic Blast? bad. Zool? bad. Power Rangers? You guessed it: bad.");
        trollScript.Add("And don't even get me started on the X-Men game. Wolverine lost health when he used his claws. Completely inconsistent with his character.");
        trollScript.Add("What, the back button? You regret not pushing it earlier when you had the chance huh?");
        trollScript.Add("Well, don't let me stop ya. No one ever listens to me pour my heart out, why should you?");
        trollScript.Add("No, no, go on. I really don't mind. I just opened up to you is all. Nothing vulnerable about me, nosir.");
        trollScript.Add("...");
        trollScript.Add("...");
        trollScript.Add("...");
        trollScript.Add("...");
        trollScript.Add("Okay, fine. You're clearly not goin' anywhere.");
        trollScript.Add("You've become engrossed in my story. I get it. I'm a master orator after all.");
        trollScript.Add("Now where was I? Oh yes, talking about my parents and videogames.");
        trollScript.Add("They eventually did get me another console. A SNES. In 1998. ");
        trollScript.Add("Sure, I might've been a little behind the times, but it was a heck of a lot better than the Game Gear, I'll tell you that.");
        trollScript.Add("My favorite game for the system by far was Super Street Fighter 2. What a game, I tells ya.");
        trollScript.Add("The love affair didn't last long though. My mother thought it was too violent, so she took it away.");
        trollScript.Add("She said she would give it back to me when I was older. Well, I'm in my 20's now, and I'm still waiting.");
        trollScript.Add("Oh, what could've been. I could've been the next Daigo had I but had the chance.");
        trollScript.Add("Instead here I am. Barely able to input a dragon punch, can't hit confirm, can't kara throw. It's a sad state I tells ya.");
        trollScript.Add("Anyways, I should let you get back to your game.");
        trollScript.Add("After all, you could become the next Daigo of Soft Drink Server Simulators. I hear it's a growing genre.");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("Seriously, you gotta leave.");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("I'm serious, you'll go over the index range.");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("I guess I could script it so you can't go over the limit, but frankly I've lost count of how many times you clicked.");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("I think it's like, 70-something.");
        trollScript.Add("Regardless, you gotta stop. Please. Push the back button.");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
        trollScript.Add("");
    }

    
    public void Next() {
        lineNum++;
        text.text = trollScript[lineNum];
        if (lineNum == 4)
            backButton.SetActive(true);

        if (lineNum == 9)
            backButton.SetActive(false);

        if (lineNum == 21)
            backButton.SetActive(true);

        if (lineNum == 28)
            backButton.SetActive(false);

        if (lineNum == 38)
            backButton.SetActive(true);
    }
}
