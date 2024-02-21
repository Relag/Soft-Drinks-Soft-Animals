using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avery : Customer
{
    public Avery() {
        name = "Avery";
        customerDrink = new FieldsFavorite(2);
    }
}
