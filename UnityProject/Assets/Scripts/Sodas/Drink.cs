using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink {
    protected int HoneyFizz;
    protected int RippleCola;
    protected int ButtonBirchBeer;
    protected bool grapeFlavouring;
    protected bool cherryFlavouring;
    protected bool strawberryFlavouring;
    protected string name;
    protected string description;


    protected enum SIZE
    {
        small, medium, large
    };

    SIZE size;

    public bool IsAccurate(Drink preparedDrink) {
        if (size != preparedDrink.size)
            return false;
        if (grapeFlavouring != preparedDrink.grapeFlavouring)
            return false;
        if (cherryFlavouring != preparedDrink.cherryFlavouring)
            return false;
        if (strawberryFlavouring != preparedDrink.strawberryFlavouring)
            return false;
        if (RippleCola > (preparedDrink.RippleCola + 5) || RippleCola < (preparedDrink.RippleCola - 5) || (HoneyFizz > (preparedDrink.HoneyFizz + 5) || HoneyFizz < (HoneyFizz - 5))
            || (ButtonBirchBeer > (preparedDrink.ButtonBirchBeer + 5) || ButtonBirchBeer < (preparedDrink.ButtonBirchBeer - 5)))
            return false;

        return true;
    }

    public string getDescription() {
        return description;
    }

    public string getRecipe() {

        if (RippleCola == 100)
        {
            string returnString = "Just a plain soda.\nJust make sure it's just Ripple Cola.";
            return returnString;
        }
        else
        {
            string returnString = name;
            returnString += "\nPepsi %" + HoneyFizz + "\nCoke %" + RippleCola + "\nRoot Beer %" + ButtonBirchBeer;

            if (grapeFlavouring)
                returnString += "\nAdd Grape Shot";
            if (cherryFlavouring)
                returnString += "\nAdd Cherry Shot";
            if (strawberryFlavouring)
                returnString += "\nAdd Strawberry Shot";

            return returnString;
        }
    }
}
