using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
                Destroy(gameObject);
    }

    public enum cup
    {
        small,
        medium,
        large,
        none
    };

   Customer currentCustomer;
    public cup size;
    //Sodas
    public int soda1 = 0;
    public int soda2 = 0;
    public int soda3 = 0;
    //Flavors
    public bool flavor1 = false;
    public bool flavor2 = false;
    public bool flavor3 = false;

    public bool PassFail = false;
    public bool hold = false;

    public Image m_Image;
    GameObject[] SizeButtons; //Including all size buttons in order to hide and show them
    GameObject[] FlavorButtons;
    GameObject[] SodaButtons;
    GameObject[] Cup;
    public GameObject NextCustomer;

    int drinkSuccess = 0;
    int drinkFail = 0;

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
        currentCustomer = new Benjamin();


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
        // OrderSetter();
        NextOrder();

    }

    public void Checkdrink() //If you're reading this I know there's a better way but I'm lazy
    {
        StopAllCoroutines();

        Drink drinkAttempt = new Drink(soda1, soda2, soda3, flavor1, flavor2, flavor3, (int)size);

        PassFail = drinkAttempt.IsAccurate(currentCustomer.GetDrink());

        if (PassFail)
            drinkSuccess++;
        else
            drinkFail++;

        EventManager();

        if (OrderNumber < 7)
            OrderNumber += 1;
        else {
            OrderNumber = 1;
            dayCount++;
        }

        if (dayCount < 5)
            NextCustomer.SetActive(true);
        else
            FinishScreen();
    }

    private void FinishScreen() {
        throw new NotImplementedException();
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


    //Start of Day management system

    //ShowText(int day, int animal, int response)

    public void NextOrder()
    {
        switch (OrderNumber)
        {
            case 1:
            currentCustomer = new Benjamin();
            m_Image.sprite = currentCustomer.GetSprite();
                StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
                break;
            case 2:
            currentCustomer = new Candi();//Candi 6
                m_Image.sprite = Candy;
                StopAllCoroutines();
                StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
                break;
            case 3:
            currentCustomer = new Gibson();//Goat 2
            m_Image.sprite = Gibson;
            StopAllCoroutines();
            StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
            break;
            case 4:
            currentCustomer = new James();//Felix 5
            m_Image.sprite = Felix;
            StopAllCoroutines();
            StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
            break;
         
            case 5:
            currentCustomer = new Felix();//Dog 3
                m_Image.sprite = JJ;
                StopAllCoroutines();
                StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
                break;
            case 6:
            currentCustomer = new Rosco();//Rosco 4
                m_Image.sprite = Rosco;
                StopAllCoroutines();
                StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
                break;
            case 7:
            currentCustomer = new Avery(); ;//Avery 7
                m_Image.sprite = Avery;
                StopAllCoroutines();
                StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount)));
                dayCount++;
                break;
        }
    }

    public int OrderNumber = 1;
    int dayCount = 1;

    public Sprite Benjamin;
    public Sprite Gibson;
    public Sprite JJ;
    public Sprite Candy;
    public Sprite Avery;
    public Sprite Felix;
    public Sprite Rosco;
    int temp = 1;

    //ShowText(int day, int animal, int response)
    public void EventManager()
    {
        StartCoroutine(ShowText(currentCustomer.GetDialogue(dayCount, Convert.ToInt32(PassFail))));
    }

    

    public Text txt;
    private string currentText = "";


    //StartCoroutine(ShowText());

    public IEnumerator ShowText(string fullText)
    {
        

        for (int i = 0; i <= fullText.Length; i++) {
            hold = true;
            currentText = fullText.Substring(0, i);
            txt.text = currentText;
            yield return new WaitForEndOfFrame();
            hold = false;
        }

    } 

}

//StartCoroutine(ShowText());

