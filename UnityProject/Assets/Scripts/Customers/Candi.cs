using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candi : Customer
{
    public Candi() {
        name = "Candi";
        customerDrink = new CheeryFloat(1);
    }
}
