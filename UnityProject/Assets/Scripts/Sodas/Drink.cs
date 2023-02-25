using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink {
    protected int pepsiPercent;
    protected int cokePercent;
    protected int rootBeerPercent;
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
        if (cokePercent > (preparedDrink.cokePercent + 5) || cokePercent < (preparedDrink.cokePercent - 5) || (pepsiPercent > (preparedDrink.pepsiPercent + 5) || pepsiPercent < (pepsiPercent - 5))
            || (rootBeerPercent > (preparedDrink.rootBeerPercent + 5) || rootBeerPercent < (preparedDrink.rootBeerPercent - 5)))
            return false;

        return true;
    }

    public string getDescription() {
        return description;
    }

    public string getRecipe() {
        string returnString = "Pepsi %" + pepsiPercent + "\nCoke %" + cokePercent + "\nRoot Beer %" + rootBeerPercent;

        if (grapeFlavouring)
            returnString += "\nAdd Grape Shot";
        if (cherryFlavouring)
            returnString += "\nAdd Cherry Shot";
        if (strawberryFlavouring)
            returnString += "\nAdd Strawberry Shot";

        return returnString;
    }
}
