using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class James : Customer {
    public James() {
        name = "James";
        customerDrink = new Drink(0, 0, 100, true, false, false, 0);
        customerSprite = Resources.Load<Sprite>("Art/JJ_Terrier");
    }
    protected override void SetDialogue() {
        throw new System.NotImplementedException();
    }
}
