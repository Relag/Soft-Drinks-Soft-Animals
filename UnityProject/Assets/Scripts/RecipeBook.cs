using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipeBook : MonoBehaviour
{
    public int page = 0;
    private int MAX_PAGE = 5;

    public TextMeshProUGUI LeftText;
    public TextMeshProUGUI RightText;
    DrCola drCola = new DrCola();
    PlainSoda plainSoda = new PlainSoda();
    SpritzyFruit spritzyFruit = new SpritzyFruit();
    FieldsFavorite fieldsFavorite = new FieldsFavorite();
    CheeryFloat cheeryFloat = new CheeryFloat();
    EverythingCup everythingCup = new EverythingCup();
    void Update()
    {
        if (page < 0)
        {
            page = 0;
        }
        else if (page > MAX_PAGE)
        {
            page = MAX_PAGE;
        }
        else
        {
            switch (page)
            {
                case 0:
                    LeftText.text = plainSoda.getRecipe();
                    RightText.text = plainSoda.getDescription();
                    break;

                case 1:
                    LeftText.text = drCola.getRecipe();
                    RightText.text = drCola.getDescription();
                    break;
                case 2:
                    LeftText.text = spritzyFruit.getRecipe();
                    RightText.text = spritzyFruit.getDescription();
                    break;
                case 3:
                    LeftText.text = fieldsFavorite.getRecipe();
                    RightText.text = fieldsFavorite.getDescription();
                    break;
                case 4:
                    LeftText.text = cheeryFloat.getRecipe();
                    RightText.text = cheeryFloat.getDescription();
                    break;
                case 5:
                    LeftText.text = cheeryFloat.getRecipe();
                    RightText.text = cheeryFloat.getDescription();
                    break;
                case 6:
                    LeftText.text = everythingCup.getRecipe();
                    RightText.text = everythingCup.getDescription();
                    break;
            }  
        }
    }

    public void PageForward()
    {
        if (page < MAX_PAGE)
        {
            page += 1;
        }
    }
    public void PageBack()
    {
        if (page > 0)
        {
            page -= 1;
        }
    }



    
    /*public string Left0 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
    public string Right0 = "sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";


    public string Left1 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
    public string Right1 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";

    public string Left2 = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";
    public string Right2 = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";

    public string Left3 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
    public string Right3 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";*/
    
}
