using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felix : Customer
{
    public Felix() {
        name = "Felix";
        customerDrink = new DrCola(0);
        customerSprite = Resources.Load<Sprite>("Art/Felix_Fisher");
    }

    protected override void SetDialogue() {
        throw new System.NotImplementedException();
    }
}
