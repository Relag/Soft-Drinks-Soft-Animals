using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avery : Customer
{
    Avery() {
        name = "Avery";
        customerDrink = new FieldsFavorite(2);
    }
}
