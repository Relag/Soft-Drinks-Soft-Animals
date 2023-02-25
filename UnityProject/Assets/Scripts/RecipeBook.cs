using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecipeBook : MonoBehaviour
{
    public int page = 0;

    public TextMeshProUGUI LeftText;
    public TextMeshProUGUI RightText;

    void Update()
    {
        if (page < 0)
        {
            page = 0;
        }
        else if (page > 3)
        {
            page = 3;
        }
        else
        {
            switch (page)
            {
                case 0:
                    LeftText.text = Left0;
                    RightText.text = Right0;
                    break;


                case 1:
                    LeftText.text = Left1;
                    RightText.text = Right1;
                    break;
                case 2:
                    LeftText.text = Left2;
                    RightText.text = Right2;
                    break;
                case 3:
                    LeftText.text = Left3;
                    RightText.text = Right3;
                    break;
            }  
        }
    }

    public void PageForward()
    {
        if (page < 3)
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

    public string Left0 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
    public string Right0 = "sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";


    public string Left1 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
    public string Right1 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";

    public string Left2 = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";
    public string Right2 = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";

    public string Left3 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
    public string Right3 = "My favorite Drink/n- 1 / 4 Soda 1/n-2/4 Soda 2/n-1/4 Soda 3/n-Flavour 2/nMedium Size/nNothing Else.";
}
