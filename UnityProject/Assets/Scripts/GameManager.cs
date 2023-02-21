using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum cup
    {
        small,
        medium,
        large,
        none
    };

    public cup size;

    //Sodas
    public int soda1 = 0;
    public int soda2 = 0;
    public int soda3 = 0;
    //Flavors
    public bool flavor1 = false;
    public bool flavor2 = false;
    public bool flavor3 = false;

    GameObject[] SizeButtons; //Including all size buttons in order to hide and show them
    GameObject[] FlavorButtons;
    GameObject[] SodaButtons;
    GameObject[] Cup;

    private void Start()
    {
        SizeButtons = GameObject.FindGameObjectsWithTag("SizeButtons");
        FlavorButtons = GameObject.FindGameObjectsWithTag("FlavorButtons");
        SodaButtons = GameObject.FindGameObjectsWithTag("SodaButtons");
        Cup = GameObject.FindGameObjectsWithTag("CupTag");
    }



    public void init()
    {
        

        size = cup.none;
        //Sodas
        soda1 = 0;
        soda2 = 0;
        soda3 = 0;
        //Flavors
        flavor1 = false;
        flavor2 = false;
        flavor3 = false;

        foreach (GameObject button in SizeButtons)
        {
            button.SetActive(true);
        }
       foreach (GameObject button2 in FlavorButtons)
        {
            button2.SetActive(true);
        }
        foreach (GameObject button3 in SodaButtons)
        {
            button3.SetActive(true);
        }
        foreach (GameObject item in Cup)
        {
            item.SetActive(false);
        }

    }

    public bool Checkdrink(int drink1, int drink2, int drink3, bool topping1, bool topping2, bool topping3, cup howbig) //If you're reading this I know there's a better way but I'm lazy
    {

        if(howbig != size)
        {
            return false;
        }
        else if (soda1 > (drink1 + 5) || soda1 < (drink1 - 5) || (soda2 > (drink2 + 5) || soda2 < (drink2 - 5)) || (soda3 > (drink3 + 5) || soda3 < (drink3 - 5))) 
        {
            return false;
        }
        else if (flavor1 != topping1 && flavor2 != topping2 && flavor3 != topping3)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    public void Small()
    {
        size = cup.small;
    }
    public void Medium()
    {
        size = cup.medium;
    }
    public void Large()
    {
        size = cup.large;
    }

    public void Flavor1()
    {
        flavor1 = true;
    }
    public void Flavor2()
    {
        flavor2 = true;
    }
    public void Flavor3()
    {
        flavor3 = true;
    }



    public void SetSize()
    {
        foreach (GameObject button in SizeButtons)
        {
            button.SetActive(false);
        }
    }
    public void HideCup()
    {
        foreach (GameObject item in Cup)
        {
            item.SetActive(false);
        }
    }
    public void ShowCup()
    {
        foreach (GameObject item in Cup)
        {
            item.SetActive(true);
        }
    }


}
