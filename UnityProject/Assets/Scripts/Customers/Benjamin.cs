using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benjamin : Customer
{
    public Benjamin() {
        customerDrink = new PlainSoda(1);
        name = "Benjamin";
        customerSprite = Resources.Load<Sprite>("Art/bear_ben");
    }
}
