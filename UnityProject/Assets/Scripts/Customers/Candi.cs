using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candi : Customer
{
    public Candi() {
        name = "Candi";
        customerDrink = new SpritzyFruit(1);
        customerSprite = Resources.Load<Sprite>("Art/Candi_Cat");
    }
    protected override void SetDialogue() {
        throw new System.NotImplementedException();
    }
}
