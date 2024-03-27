using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gibson : Customer {
    public Gibson() {
        name = "Gibson";
        customerDrink = new EverythingCup(2);
        customerSprite = Resources.Load<Sprite>("Art/Gibson_Goat");
        SetDialogue();
    }
    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Huh? Oh. Uh—the one with everything. Large.");
        dialogue[1].Add(1, "Oh. Right. Drink. This is good, thank you.");
        dialogue[1].Add(0, "Um...aack! This appears to be...not what I ordered. JJ, did I order it wrong again? I probably did. Darn. This paper...");
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "What, I’m in the middle of a sentence—oh, we’re here. Large Everything Cup, please, thank you.");
        dialogue[2].Add(1, "The implications of stuffed animal life being legitimized only through the complete bodily transformation into flesh and blood, thus erasing the identity of “stuffed” entirely, constitute, frankly, an existential nightmare, in which—oh. Thank you. Thank you, JJ.");
        dialogue[2].Add(0, "—thus, the question becomes: how does one define reality? Does a sentient stuffed lifeform experience reality, or does reality only begin at the moment of transformation to organic? If the sentient stuffed lifeform does not experience reality, in what way are they sentient; what do they experience? Oh. Um. This is...unexpected. I didn’t order this. May I still drink it? I don’t want to keep standing in line.");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "Hello, sorry—you know which one. Has it really been twenty-one years, JJ?");
        dialogue[3].Add(1, "I know I’ve been...busy. But—once I’ve got my doctorate, there’s a lot of things I need to—oh, thank you. You’re my best friend, JJ, you know that?");
        dialogue[3].Add(0, "I know I’ve been...busy. But—once I’ve got my doctorate, there’s a lot of things I need to—oh. Hmm. This is...not the right drink. You’re my best friend, JJ, you know that? Even if you take me to soda bars that get my order wrong.");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "I can’t, JJ. I barely have time to come to the soda bar. It’s due in...6 hours, 13 minutes. Also, why would you want to take me on a walk, look at me. Um—hello, you know which one, right?");
        dialogue[4].Add(1, "JJ, wait a second. Wait, don’t get upset—thank you for the drink. I guess.");
        dialogue[4].Add(0, "JJ, wait a second. Wait, don’t get upset—and the drink’s wrong, too. Argh!");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Hello, I’d like to order the...this feels weird. You know which one.");
        dialogue[5].Add(1, "Do you want to try mine, JJ? Is that, um—proper date behavior? I am...messing this up so badly already. But—I like being here with you.");
        dialogue[5].Add(0, "Do you want mine, JJ? They got it wrong, but I’ve heard sharing is, um—proper date behavior? I am...messing this up as badly as they messed up this drink. But—I like being here with you.");
    }
}
