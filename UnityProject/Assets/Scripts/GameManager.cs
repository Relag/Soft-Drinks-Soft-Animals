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




    cup size;
    //Sodas
    int soda1 = 0;
    int soda2 = 0;
    int soda3 = 0;
    //Flavors
    bool flavor1 = false;
    bool flavor2 = false;
    bool flavor3 = false;

    public void init()
    {
        

        size = cup.none;
        //Sodas
        int soda1 = 0;
        int soda2 = 0;
        int soda3 = 0;
        //Flavors
        bool flavor1 = false;
        bool flavor2 = false;
        bool flavor3 = false;

        foreach (GameObject button in SizeButtons)
        {
            button.SetActive(true);
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
    GameObject[] SizeButtons; //Including all size buttons in order to hide and show them
    private void Start()
    {
        SizeButtons = GameObject.FindGameObjectsWithTag("SizeButtons");
    }

    public void SetSize()
    {


        foreach (GameObject button in SizeButtons)
        {
            button.SetActive(false);
        }

    }

}
