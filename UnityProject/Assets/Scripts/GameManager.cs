using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        void Awake() {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
                Destroy(gameObject);
        }
    }

    public enum cup
    {
        small,
        medium,
        large,
        none
    };

    //Set these values at start of level and after each success or fail
    public int drink1;
    public int drink2;
    public int drink3;
    public bool topping1;
    public bool topping2;
    public bool topping3;
    public cup howbig;


    public cup size;
    public GameObject succorfail;
    //Sodas
    public int soda1 = 0;
    public int soda2 = 0;
    public int soda3 = 0;
    //Flavors
    public bool flavor1 = false;
    public bool flavor2 = false;
    public bool flavor3 = false;

    public bool PassFail = false;

    public int OrderNumber = 1;

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
        init();
    }



    public void init()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = false;
        topping2 = true;
        topping3 = false;
        howbig = cup.medium;



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

    public void Checkdrink() //If you're reading this I know there's a better way but I'm lazy
    {

        if (howbig != size)
        {
            PassFail = false;
        }
        else if (soda1 > (drink1 + 5) || soda1 < (drink1 - 5) || (soda2 > (drink2 + 5) || soda2 < (drink2 - 5)) || (soda3 > (drink3 + 5) || soda3 < (drink3 - 5)))
        {
            PassFail = false;
        }
        else if (flavor1 == topping1 && flavor2 == topping2 && flavor3 == topping3)
        {
            PassFail = true;
            OrderNumber += 1;
            
        }
        else
        {
            PassFail = false;
        }
        ChangeOrder();
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



    //Main Game Controls Here
    public void TrashDrink()
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
    }

    public void ChangeOrder()
    {
        switch (OrderNumber)
        {
            case 2:
                Day1Order2();
                break;
            case 3:
                Day1Order3();
                break;
            case 4:
                Day1Order4();
                break;
            case 5:
                Day1Order5();
                break;
            case 6:
                Day1Order6();
                break;
            case 7:
                Day1Order7();
                break;





            case < 7:
                Debug.Log("error");
                OrderNumber = 7;
                break;

            case > 2:
                Debug.Log("error");
                OrderNumber = 2;
                break;
        }
    }










    void Day1Order2()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = true;
        topping2 = true;
        topping3 = false;
        howbig = cup.large;
    }
    void Day1Order3()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = true;
        topping2 = true;
        topping3 = false;
        howbig = cup.large;
    }
    void Day1Order4()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = true;
        topping2 = true;
        topping3 = false;
        howbig = cup.large;
    }
    void Day1Order5()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = true;
        topping2 = true;
        topping3 = false;
        howbig = cup.large;
    }
    void Day1Order6()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = true;
        topping2 = true;
        topping3 = false;
        howbig = cup.large;
    }
    void Day1Order7()
    {
        drink1 = 25;
        drink2 = 50;
        drink3 = 25;
        topping1 = true;
        topping2 = true;
        topping3 = false;
        howbig = cup.large;
    }





}
