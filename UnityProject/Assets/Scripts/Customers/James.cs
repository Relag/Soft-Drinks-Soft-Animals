using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class James : Customer {
    public James() {
        name = "James";
        customerDrink = new Drink(0, 0, 100, true, false, false, 0);
        customerSprite = Resources.Load<Sprite>("Art/JJ_Terrier");
        SetDialogue();
    }
    protected override void SetDialogue() {
        dialogue[1] = new Dictionary<int, string>();
        dialogue[1].Add(2, "Hey! I heard there was a new person in town. I’m James—you can call me JJ—and that was Gibson. Don’t mind him, his thesis is draining all the stuffing out of him. He’s usually more—well, actually, he’s pretty much always like this. Can I get a small grape birch beer?");
        dialogue[1].Add(1, "Thanks! Come on, Gib, let’s sit down before you fall over.");
        dialogue[1].Add(0, "Uh, that is...not how I remembered it tasting. Oh, well. Still good. Gib, let’s sit down before you fall over.");
        dialogue[2] = new Dictionary<int, string>();
        dialogue[2].Add(2, "Hey, could I get a grape soda, please? And I’ll cover Gibson.");
        dialogue[2].Add(1, "Thanks so much. Gibson, I don’t have any clue what you’re saying, but it sounds smart? Like always. You can take a minute to breathe, you know.");
        dialogue[2].Add(0, "Uh...sure, okay, I’ll take it. Close enough. Gibson, I don’t have any clue what you’re saying, but it sounds smart? Like always. You can take a minute to breathe, you know.");
        dialogue[3] = new Dictionary<int, string>();
        dialogue[3].Add(2, "Hey, same as always, please? Yes, Gib, it’s been exactly twenty-one years since I stole your can out of the sandbox.");
        dialogue[3].Add(1, "Thank you, that tastes awesome. Hey Gibson, we should celebrate. Would you maybe want to...uh, you know, never mind.");
        dialogue[3].Add(0, "Um...thanks. It’s, uh—not what I expected, but sometimes you gotta change it up, I guess? Hey Gibson, we should celebrate our sandbox day. Would you maybe want to...uh, you know, never mind.");
        dialogue[4] = new Dictionary<int, string>();
        dialogue[4].Add(2, "Don’t get upset? I never ask you for anything, except for this! One walk in the park. We just finished landscaping it, and I know you’d like it. I mean, I know I’m the outdoors guy and you’re, uh...not, but I swear, it’s really nice, and it would only take a minute, I just—hey there, same as always. Please.");
        dialogue[4].Add(1, "Thanks. All right, whatever, Gibson. Go get another doctorate before you have time for me.");
        dialogue[4].Add(0, "And this isn’t even the right—whatever. You can mess up the soda. Gibson can go get another doctorate before he makes time for me. I don’t care.");
        dialogue[5] = new Dictionary<int, string>();
        dialogue[5].Add(2, "Same as always, please! I’m sorry about yesterday. It’s, uh...a better day now.");
        dialogue[5].Add(1, "I didn’t think we’d get here, you know? I’ve had a crush on this guy for ages. And I never thought—well, it’s better than what I thought. Being with him. It’s the best thing that’s ever happened to me—no offense to your grape sodas!");
        dialogue[5].Add(0, "Aw, man, this isn’t—you know what? It’s fine. It’s crazy that Gib and I are on a date in the first place. I’ve had a crush on this guy for ages. And I never thought—well, it’s better than what I thought. Being with him. It’s the best thing that’s ever happened to me—full offense to your grape sodas!");
    }
}
