using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gibson : Customer {
    public Gibson() {
        name = "Gibson";
        customerDrink = new EverythingCup(2);
        customerSprite = Resources.Load<Sprite>("Art/Gibson_Goat");
    }
    protected override void SetDialogue() {
        throw new System.NotImplementedException();
    }
}
