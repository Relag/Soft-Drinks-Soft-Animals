using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public int HoneyFizz;
    public int RippleCola;
    public int BirchBeer;
    public bool cherryFlavouring;
    public bool strawberryFlavouring;
    public bool grapeFlavouring;
    public cup howbig;


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
        HoneyFizz = 0;
        RippleCola = 0;
        BirchBeer = 0;
        cherryFlavouring = false;
        strawberryFlavouring = false;
        grapeFlavouring = false;
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
        OrderSetter();

    }

    public void Checkdrink() //If you're reading this I know there's a better way but I'm lazy
    {

        if (howbig != size)
        {
            PassFail = false;

            OrderNumber += 1 ;
            EventManager();
        }
        else if (soda1 > (HoneyFizz + 5) || soda1 < (HoneyFizz - 5) || (soda2 > (RippleCola + 5) || soda2 < (RippleCola - 5)) || (soda3 > (BirchBeer + 5) || soda3 < (BirchBeer - 5)))
        {
            PassFail = false;

            OrderNumber += 1;
            EventManager();
        }
        else if (flavor1 == cherryFlavouring && flavor2 == strawberryFlavouring && flavor3 == grapeFlavouring)
        {
            PassFail = true;

            OrderNumber += 1;
            EventManager();
        }
        else
        {
            PassFail = false;

            OrderNumber += 1;
            EventManager();
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

    public void ChangeOrderDay1()
    {
        switch (OrderNumber)
        {
            case 1:
                PlainSoda();//Bear 1
                m_Image.sprite = Benjamin;
                StartCoroutine(ShowText(1, 1, 1));
                break;
            case 2:
                CheeryFloat();//Candi 6
                m_Image.sprite = Candy;
                StopAllCoroutines();
                StartCoroutine(ShowText(1, 6, 1));
                break;
            case 3:
                DrCola();//Felix 5
                m_Image.sprite = Felix;
                StopAllCoroutines();
                StartCoroutine(ShowText(1, 5, 1));
                break;
            case 4:
                EverythingCup();//Goat 2
                m_Image.sprite = Gibson;
                StopAllCoroutines();
                StartCoroutine(ShowText(1, 2, 1));
                break;
            case 5:
                FieldsFavorite();//Dog 3
                m_Image.sprite = JJ;
                StopAllCoroutines();
                StartCoroutine(ShowText(1, 3, 1));
                break;
            case 6:
                SpritzyFruit();//Rosco 4
                m_Image.sprite = Rosco;
                StopAllCoroutines();
                StartCoroutine(ShowText(1, 4, 1));
                break;
            case 7:
                FieldsFavorite();//Avery 7
                m_Image.sprite = Avery;
                StopAllCoroutines();
                StartCoroutine(ShowText(1, 7, 1));
                dayCount++;
                break;
        }
    }
    public void ChangeOrderDay2()
    {
        switch (OrderNumber)
        {
            case 1:
                PlainSoda();//Bear
                m_Image.sprite = Benjamin;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 1, 1));
                break;
            case 2:
                FieldsFavorite();//Avery
                m_Image.sprite = Avery;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 7, 1));
                break;
            case 3:
                SpritzyFruit();//Rosco
                m_Image.sprite = Rosco;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 4, 1));
                break;
            case 4:
                EverythingCup();//Goat
                m_Image.sprite = Gibson;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 2, 1));
                break;
            case 5:
                FieldsFavorite();//Dog
                m_Image.sprite = JJ;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 3, 1));
                break;
            case 6:
                DrCola();//Felix
                m_Image.sprite = Felix;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 5, 1));
                break;
            case 7:
                CheeryFloat();//Candi
                m_Image.sprite = Candy;
                StopAllCoroutines();
                StartCoroutine(ShowText(2, 6, 1));
                dayCount++;
                break;
        }
    }
    public void ChangeOrderDay3()
    {
        switch (OrderNumber)
        {
            case 1:
                PlainSoda();//Bear
                m_Image.sprite = Benjamin;
                StartCoroutine(ShowText(3, 1, 1));
                break;
            case 2:
                DrCola();//Felix
                m_Image.sprite = Felix;
                StartCoroutine(ShowText(3, 5, 1));
                break;
            case 3:
                CheeryFloat();//Candi
                m_Image.sprite = Candy;
                StartCoroutine(ShowText(3, 6, 1));
                break;
            case 4:
                EverythingCup();//Goat
                m_Image.sprite = Gibson;
                StartCoroutine(ShowText(3, 2, 1));
                break;
            case 5:
                FieldsFavorite();//Dog
                m_Image.sprite = JJ;
                StartCoroutine(ShowText(3, 3, 1));
                break;
            case 6:
                FieldsFavorite();//Avery
                m_Image.sprite = Avery;
                StartCoroutine(ShowText(3, 7, 1));
                break;
            case 7:
                SpritzyFruit();//Rosco
                m_Image.sprite = Rosco;
                StartCoroutine(ShowText(3, 4, 1));
                break;
        }
    }
    public void ChangeOrderDay4()
    {
        switch (OrderNumber)
        {
            case 1:
                PlainSoda();//Bear
                m_Image.sprite = Benjamin;
                StartCoroutine(ShowText(4, 1, 1));
                break;
            case 2:
                FieldsFavorite();//Avery
                m_Image.sprite = Avery;
                StartCoroutine(ShowText(4, 7, 1));
                break;
            case 3:
                SpritzyFruit();//Rosco
                m_Image.sprite = Rosco;
                StartCoroutine(ShowText(4, 4, 1));
                break;
            case 4:
                EverythingCup();//Goat
                m_Image.sprite = Gibson;
                StartCoroutine(ShowText(4, 2, 1));
                break;
            case 5:
                FieldsFavorite();//Dog
                m_Image.sprite = JJ;
                StartCoroutine(ShowText(4, 3, 1));
                break;
            case 6:
                CheeryFloat();//Candi
                m_Image.sprite = Candy;
                StartCoroutine(ShowText(4, 6, 1));
                break;
            case 7:
                DrCola();//Felix
                m_Image.sprite = Felix;
                StartCoroutine(ShowText(4, 5, 1));
                break;
        }
    }
    public void ChangeOrderDay5()
    {
        switch (OrderNumber)
        {
            case 1:
                PlainSoda();//Bear
                m_Image.sprite = Benjamin;
                StartCoroutine(ShowText(5, 1, 1));
                break;
            case 2:
                CheeryFloat();//Candi
                m_Image.sprite = Candy;
                StartCoroutine(ShowText(5, 6, 1));
                break;
            case 3:
                FieldsFavorite();//Avery
                m_Image.sprite = Avery;
                StartCoroutine(ShowText(5, 7, 1));
                break;
            case 4:
                EverythingCup();//Goat
                m_Image.sprite = Gibson;
                StartCoroutine(ShowText(2, 7, 1));
                break;
            case 5:
                FieldsFavorite();//Dog
                m_Image.sprite = JJ;
                StartCoroutine(ShowText(5, 3, 1));
                break;
            case 6:
                SpritzyFruit();//Rosco
                m_Image.sprite = Rosco;
                StartCoroutine(ShowText(5, 4, 1));
                break;
            case 7:
                DrCola();//Felix
                m_Image.sprite = Felix;
                StartCoroutine(ShowText(5, 5, 1));
                break;
        }
    }










    void CheeryFloat()
    {
        HoneyFizz = 25;
        RippleCola = 75;
        BirchBeer = 0;
        cherryFlavouring = true;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        howbig = cup.medium;
    }
    void DrCola()
    {
        HoneyFizz = 25;
        RippleCola = 25;
        BirchBeer = 50;
        cherryFlavouring = false;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        howbig = cup.small;
    }
    void PlainSoda()
    {
        HoneyFizz = 0;
        RippleCola = 100;
        BirchBeer = 0;
        cherryFlavouring = false;
        strawberryFlavouring = false;
        grapeFlavouring = false;
        howbig = cup.large;
    }
    void FieldsFavorite()
    {
        HoneyFizz = 0;
        RippleCola = 50;
        BirchBeer = 50;
        cherryFlavouring = true;
        strawberryFlavouring = true;
        grapeFlavouring = true;
        howbig = cup.large;
    }
    void EverythingCup()
    {
        HoneyFizz = 25;
        RippleCola = 25;
        BirchBeer = 50;
        cherryFlavouring = true;
        strawberryFlavouring = true;
        grapeFlavouring = true;
        howbig = cup.large;
    }
    void SpritzyFruit()
    {
        HoneyFizz = 100;
        RippleCola = 0;
        BirchBeer = 0;
        cherryFlavouring = false;
        strawberryFlavouring = true;
        grapeFlavouring = false;
        howbig = cup.large;
    }

    public int OrderNumber = 1;
    int dayCount = 1;
    public void OrderSetter()
    {
        switch (dayCount)
        {
            case 1:
                ChangeOrderDay1();
                break;
            case 2:
                ChangeOrderDay2();
                break;
            case 3:
                ChangeOrderDay3();
                break;
            case 4:
                ChangeOrderDay4();
                break;
            case 5:
                ChangeOrderDay5();
                break;
        }
    }

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
        switch (dayCount)
        {
            case 1:
                if(PassFail == true)
                {
                    StartCoroutine(ShowText(1,OrderNumber,2));
                    OrderSetter();
                }
                else
                {
                    StartCoroutine(ShowText(1, OrderNumber, 3));
                    OrderSetter();
                }
                break;
            case 2:
                if (PassFail == true)
                {
                    StartCoroutine(ShowText(2, OrderNumber, 5));
                    OrderSetter();
                }
                else
                {
                    StartCoroutine(ShowText(2, OrderNumber, 6));
                    OrderSetter();
                }
                break;
            case 3:
                if (PassFail == true)
                {
                    StartCoroutine(ShowText(3, OrderNumber, 8));
                    OrderSetter();
                }
                else
                {
                    StartCoroutine(ShowText(3, OrderNumber, 9));
                    OrderSetter();
                }
                break;
            case 4:
                if (PassFail == true)
                {
                    StartCoroutine(ShowText(4, OrderNumber, 11));
                    OrderSetter();
                }
                else
                {
                    StartCoroutine(ShowText(4, OrderNumber, 12));
                    OrderSetter();
                }
                break;
            case 5:
                if (PassFail == true)
                {
                    StartCoroutine(ShowText(5, OrderNumber, 14));
                    OrderSetter();
                }
                else
                {
                    StartCoroutine(ShowText(5, OrderNumber, 15));
                    OrderSetter();
                }
                break;
        }
    }

    

    public Text txt;
    public float delay = 0.1f;
    private string currentText = "";


    //StartCoroutine(ShowText());

    public IEnumerator ShowText(int day, int animal, int response)
    {
        string fullText = "";
        switch (response)
        {
            case 1:
                if (day == 1)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[0];
                            break;
                        case 2:
                            fullText = CandiD[0];
                            break;
                        case 3:
                            fullText = FelixD[0];
                            break;
                        case 4:
                            fullText = GibsonD[0];
                            break;
                        case 5:
                            fullText = JamesD[0];
                            break;
                        case 6:
                            fullText = RoscoD[0];
                            break;
                        case 7:
                            fullText = AveryD[0];
                            break;
                    }
                }
                if (day == 2)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[3];
                            break;
                        case 2:
                            fullText = AveryD[3];
                            break;
                        case 3:
                            fullText = RoscoD[3];
                            break;
                        case 4:
                            fullText = GibsonD[3];
                            break;
                        case 5:
                            fullText = JamesD[3];
                            break;
                        case 6:
                            fullText = FelixD[3];
                            break;
                        case 7:
                            fullText = CandiD[3];
                            break;
                    }
                }
                if (day == 3)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[6];
                            break;
                        case 2:
                            fullText = FelixD[6];
                            break;
                        case 3:
                            fullText = CandiD[6];
                            break;
                        case 4:
                            fullText = GibsonD[6];
                            break;
                        case 5:
                            fullText = JamesD[6];
                            break;
                        case 6:
                            fullText = AveryD[6];
                            break;
                        case 7:
                            fullText = RoscoD[6];
                            break;
                    }
                }
                if (day == 4)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[9];
                            break;
                        case 2:
                            fullText = AveryD[9];
                            break;
                        case 3:
                            fullText = RoscoD[9];
                            break;
                        case 4:
                            fullText = GibsonD[9];
                            break;
                        case 5:
                            fullText = JamesD[9];
                            break;
                        case 6:
                            fullText = CandiD[9];
                            break;
                        case 7:
                            fullText = FelixD[9];
                            break;
                    }
                }
                if (day == 5)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[12];
                            break;
                        case 2:
                            fullText = CandiD[12];
                            break;
                        case 3:
                            fullText = AveryD[12];
                            break;
                        case 4:
                            fullText = GibsonD[12];
                            break;
                        case 5:
                            fullText = JamesD[12];
                            break;
                        case 6:
                            fullText = RoscoD[12];
                            break;
                        case 7:
                            fullText = FelixD[12];
                            break;
                    }
                }
                break;
            case 2:
                if (day == 1)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[1];
                            break;
                        case 2:
                            fullText = CandiD[1];
                            break;
                        case 3:
                            fullText = FelixD[1];
                            break;
                        case 4:
                            fullText = GibsonD[1];
                            break;
                        case 5:
                            fullText = JamesD[1];
                            break;
                        case 6:
                            fullText = RoscoD[1];
                            break;
                        case 7:
                            fullText = AveryD[1];
                            break;
                    }
                }
                if (day == 2)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[4];
                            break;
                        case 2:
                            fullText = AveryD[4];
                            break;
                        case 3:
                            fullText = RoscoD[4];
                            break;
                        case 4:
                            fullText = GibsonD[4];
                            break;
                        case 5:
                            fullText = JamesD[4];
                            break;
                        case 6:
                            fullText = FelixD[4];
                            break;
                        case 7:
                            fullText = CandiD[4];
                            break;
                    }
                }
                if (day == 3)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[7];
                            break;
                        case 2:
                            fullText = FelixD[7];
                            break;
                        case 3:
                            fullText = CandiD[7];
                            break;
                        case 4:
                            fullText = GibsonD[7];
                            break;
                        case 5:
                            fullText = JamesD[7];
                            break;
                        case 6:
                            fullText = AveryD[7];
                            break;
                        case 7:
                            fullText = RoscoD[7];
                            break;
                    }
                }
                if (day == 4)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[10];
                            break;
                        case 2:
                            fullText = AveryD[10];
                            break;
                        case 3:
                            fullText = RoscoD[10];
                            break;
                        case 4:
                            fullText = GibsonD[10];
                            break;
                        case 5:
                            fullText = JamesD[10];
                            break;
                        case 6:
                            fullText = CandiD[10];
                            break;
                        case 7:
                            fullText = FelixD[10];
                            break;
                    }
                }
                if (day == 5)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[13];
                            break;
                        case 2:
                            fullText = CandiD[13];
                            break;
                        case 3:
                            fullText = AveryD[13];
                            break;
                        case 4:
                            fullText = GibsonD[13];
                            break;
                        case 5:
                            fullText = JamesD[13];
                            break;
                        case 6:
                            fullText = RoscoD[13];
                            break;
                        case 7:
                            fullText = FelixD[13];
                            break;
                    }
                }
                break;
            case 3:
                if (day == 1)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[2];
                            break;
                        case 2:
                            fullText = CandiD[2];
                            break;
                        case 3:
                            fullText = FelixD[2];
                            break;
                        case 4:
                            fullText = GibsonD[2];
                            break;
                        case 5:
                            fullText = JamesD[2];
                            break;
                        case 6:
                            fullText = RoscoD[2];
                            break;
                        case 7:
                            fullText = AveryD[2];
                            break;
                    }
                }
                if (day == 2)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[5];
                            break;
                        case 2:
                            fullText = AveryD[5];
                            break;
                        case 3:
                            fullText = RoscoD[5];
                            break;
                        case 4:
                            fullText = GibsonD[5];
                            break;
                        case 5:
                            fullText = JamesD[5];
                            break;
                        case 6:
                            fullText = FelixD[5];
                            break;
                        case 7:
                            fullText = CandiD[5];
                            break;
                    }
                }
                if (day == 3)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[8];
                            break;
                        case 2:
                            fullText = FelixD[8];
                            break;
                        case 3:
                            fullText = CandiD[8];
                            break;
                        case 4:
                            fullText = GibsonD[8];
                            break;
                        case 5:
                            fullText = JamesD[8];
                            break;
                        case 6:
                            fullText = AveryD[8];
                            break;
                        case 7:
                            fullText = RoscoD[8];
                            break;
                    }
                }
                if (day == 4)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[11];
                            break;
                        case 2:
                            fullText = AveryD[11];
                            break;
                        case 3:
                            fullText = RoscoD[11];
                            break;
                        case 4:
                            fullText = GibsonD[11];
                            break;
                        case 5:
                            fullText = JamesD[11];
                            break;
                        case 6:
                            fullText = CandiD[11];
                            break;
                        case 7:
                            fullText = FelixD[11];
                            break;
                    }
                }
                if (day == 5)
                {
                    switch (animal)
                    {
                        case 1:
                            fullText = BenjaminD[14];
                            break;
                        case 2:
                            fullText = CandiD[14];
                            break;
                        case 3:
                            fullText = AveryD[14];
                            break;
                        case 4:
                            fullText = GibsonD[14];
                            break;
                        case 5:
                            fullText = JamesD[14];
                            break;
                        case 6:
                            fullText = RoscoD[14];
                            break;
                        case 7:
                            fullText = FelixD[14];
                            break;
                    }
                }
                break;


        }


        for (int i = 0; i <= fullText.Length; i++)
        {
            hold = true;
            currentText = fullText.Substring(0, i);
            txt.text = currentText;
            yield return new WaitForSeconds(delay);
            hold = false;
        }

    }


    public string[] BenjaminD = new string[]
    {
       "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
        "Howdy! You must be Dora’s kid—you look just like her. I’m Benjamin Bearenthal, but you can call me Benny. Oh, I guess you’ll be needing my order! Dora always remembered it...Just a medium plain soda for me.",
       "Just how I like it. Well, I hope you like it here in the city. Come on down to the post office if you need a friendly face.",
       "Hmm...maybe you just need some practice, huh? You’ll get it.",
       "Howdy! Medium plain soda for me, we don’t change around here. I remember when Dora started this place...",
       "...and Alan snorted grape soda right out his nose, the poor gator...was I going on again? Thank you.",
       "...and Alan...wait, what’d you give me? That’s not right. Are you one of those youngins who loves playing jokes on their elders? I’ll let it go. I was young once, too.",
       "Howdy! Whew, it’s always a day when the candy stamps overflow. You got the usual?",
       "That hits the spot. Can you believe those youngins want me to retire? What would they do without me?",
       "Well, uh...they can’t all be winners, can they? Thanks for trying, kiddo. At least you don’t keep telling me I ought to retire.",
       "Howdy. Just the usual.",
       "Thanks, kiddo. At least the soda stays the same. You don’t see anyone trying to leave plain soda behind.",
       "It’s fine, kiddo...no respect, and now no soda. Why do I even try?",
       "Howdy! The usual?",
       "You know, you’ve always got my order, kiddo. Helping me out. Maybe that’s all those yougins are trying to do—help an old man out. Maybe once I retire...I’ll have more time to try all these newfangled sodas, huh?",
       "Those soda machines broken, kiddo? Haha, it’s all right. We all make mistakes—but we’ve got time. Maybe that’s all those youngins were trying to do—give me more time. Well, I reckon that’s an idea worth considering."
    };

    public string[] GibsonD = new string[]
        {
            "aaaaaaaaaaaaaaaa",
            "Huh? Oh. Uh—the one with everything. Large.",
            "Oh. Right. Drink. This is good, thank you.",
            "Um...aack! This appears to be...not what I ordered. JJ, did I order it wrong again? I probably did. Darn. This paper...",
            "What, I’m in the middle of a sentence—oh, we’re here. Large Everything Cup, please, thank you.",
            "The implications of stuffed animal life being legitimized only through the complete bodily transformation into flesh and blood, thus erasing the identity of “stuffed” entirely, constitute, frankly, an existential nightmare, in which—oh. Thank you. Thank you, JJ.",
            "—thus, the question becomes: how does one define reality? Does a sentient stuffed lifeform experience reality, or does reality only begin at the moment of transformation to organic? If the sentient stuffed lifeform does not experience reality, in what way are they sentient; what do they experience? Oh. Um. This is...unexpected. I didn’t order this. May I still drink it? I don’t want to keep standing in line.",
            "Hello, sorry—you know which one. Has it really been twenty-one years, JJ?",
            "I know I’ve been...busy. But—once I’ve got my doctorate, there’s a lot of things I need to—oh, thank you. You’re my best friend, JJ, you know that?",
            "I know I’ve been...busy. But—once I’ve got my doctorate, there’s a lot of things I need to—oh. Hmm. This is...not the right drink. You’re my best friend, JJ, you know that? Even if you take me to soda bars that get my order wrong.",
            "I can’t, JJ. I barely have time to come to the soda bar. It’s due in...6 hours, 13 minutes. Also, why would you want to take me on a walk, look at me. Um—hello, you know which one, right?",
            "JJ, wait a second. Wait, don’t get upset—thank you for the drink. I guess.",
            "JJ, wait a second. Wait, don’t get upset—and the drink’s wrong, too. Argh!",
            "Hello, I’d like to order the...this feels weird. You know which one.",
            "Do you want to try mine, JJ? Is that, um—proper date behavior? I am...messing this up so badly already. But—I like being here with you.",
            "Do you want mine, JJ? They got it wrong, but I’ve heard sharing is, um—proper date behavior? I am...messing this up as badly as they messed up this drink. But—I like being here with you."
        };

    public string[] JamesD = new string[]
    {
        "a","Hey! I heard there was a new person in town. I’m James—you can call me JJ—and that was Gibson. Don’t mind him, his thesis is draining all the stuffing out of him. He’s usually more—well, actually, he’s pretty much always like this. Can I get a small grape root beer?",
        "Thanks! Come on, Gib, let’s sit down before you fall over.",
        "Uh, that is...not how I remembered it tasting. Oh, well. Still good. Gib, let’s sit down before you fall over.",
        "Hey, could I get a grape soda, please? And I’ll cover Gibson.",
        "Thanks so much. Gibson, I don’t have any clue what you’re saying, but it sounds smart? Like always. You can take a minute to breathe, you know.",
        "Uh...sure, okay, I’ll take it. Close enough. Gibson, I don’t have any clue what you’re saying, but it sounds smart? Like always. You can take a minute to breathe, you know.",
        "Hey, same as always, please? Yes, Gib, it’s been exactly twenty-one years since I stole your can out of the sandbox.",
        "Thank you, that tastes awesome. Hey Gibson, we should celebrate. Would you maybe want to...uh, you know, never mind.",
        "Um...thanks. It’s, uh—not what I expected, but sometimes you gotta change it up, I guess? Hey Gibson, we should celebrate our sandbox day. Would you maybe want to...uh, you know, never mind.",
        "Don’t get upset? I never ask you for anything, except for this! One walk in the park. We just finished landscaping it, and I know you’d like it. I mean, I know I’m the outdoors guy and you’re, uh...not, but I swear, it’s really nice, and it would only take a minute, I just—hey there, same as always. Please.",
        "Thanks. All right, whatever, Gibson. Go get another doctorate before you have time for me.",
        "And this isn’t even the right—whatever. You can mess up the soda. Gibson can go get another doctorate before he makes time for me. I don’t care.",
        "Same as always, please! I’m sorry about yesterday. It’s, uh...a better day now.",
        "I didn’t think we’d get here, you know? I’ve had a crush on this guy for ages. And I never thought—well, it’s better than what I thought. Being with him. It’s the best thing that’s ever happened to me—no offense to your grape sodas!",
        "Aw, man, this isn’t—you know what? It’s fine. It’s crazy that Gib and I are on a date in the first place. I’ve had a crush on this guy for ages. And I never thought—well, it’s better than what I thought. Being with him. It’s the best thing that’s ever happened to me—full offense to your grape sodas!"
    };

    public string[] RoscoD = new string[]
    {
       "a", "Hello there. Uh, I think I will go with the Medium Spritzy Fruit-to-Go if you don’t mind. Cool?",
        "Thanks.",
        "Uh, not exactly what I wanted, but, it’s okay…I guess.",
        "Oh hey, it’s you again. Cool. Uh, how are you? I guess? Uh, I’ll take the Spritzy Fruit-to-Go, just to make it easy. It was…really good, last time.",
        "That really hit the spot. Thank you so much, I really like these flavors together.",
        "Oh, uh…that’s alright. Mistakes happen. Still being in school, I know that all too well. You’ll get the hang of it…I guess.",
        "Hey. Wow, you work here every day? That’s dedication. Maybe one day when I finish my studies of electrical engineering, I can come here. Although there may be too many people for me…heheh. Anyways, do you remember my usual? It’s okay, if you don’t, I guess, yeah. I’d like that.",
        "You…remembered. That’s nice. Mmmm, even the drinks at my school are nothing compared to this. Even with all the people, maybe it may be worthwhile coming here more often.",
        "I guess you didn’t remember then…that’s fine. It happens to the best of us. I remember one time I forgot my sister’s birthday and gave her a makeshift gift out of gears and wires I found being thrown away. She forgave me though…eventually…",
        "Hello. How’s it going? Working hard today? I hope it’s not too busy, I don’t know if I could ever manage being here for too long. The bright lights kind of hurt my eyes, but here it’s not so bad. Oh yeah, I’ll have my usual again, but it’s not for me. It’ll be for my brother this time.",
        "Mmmm just as great as ever. I cannot wait to have my brother try this. Maybe he could share with the rest of us. My mom and dad don’t like fizzy drinks often, but I think this may just change all of their minds. You’re like, a drink scientist.",
        "Yeah, no, still not it…I’m guessing you forgot. I’m usually pretty forgettable so I understand. I’ll still take it though, I’m sure, someone will take it off my hands…maybe.",
        "Quite a busy time. Glad it’s the end of the week, I hope you’re doing well. Had a big math test today but I am so glad for it to be over! So, I’m here to celebrate with a good drink…or cheer myself up, preemptively anyway. I’ll find out either way in a few days. At least now I can relax and stay home for a few days. Catch on my sleep. But for now, drink time.",
        "Now that I think about it, I think these must be the best drinks in the city. You get them right and tasty. I think I’ll keep on coming here.",
        "This isn’t what I wanted…I’m sorry. I’m not mad, just disappointed."
    };

    public string[] FelixD = new string[]
        {
           "a", "Yes, hello. Sorry one sec! *phone chatter* Sorry, very important meeting. Let me have the Small Dr. Cola please.",
            "Ahh thank you. Here, exact change, as calculated.",
            "Oh uh, perhaps it’s just the ratios that are off. Even Pythagoras got some initial theories wrong, right?",
            "Oh hey, you served me approximately 23 hours, 49 minutes and 37 seconds ago! What are the chances? Exactly 67.8%, of course. I shall have the Dr. Cola again.",
            "Excellent, this was certainly created by someone who understands the natural order of substances. Well done.",
            "Well, I must say, it isn’t the worst thing I’ve seen. Perhaps you should take note of my students, now while kids can surprise you, kids can also disappoint you.",
            "Oh, it’s you, good! What is the probability that I will be able to get a *insert drink name here* in approximately 1 minute and 37 seconds? I lost track of all time while reading Orwell’s ‘Down and Out In Paris and London’! Talk about one of the best memoirs of all time. I don’t mean to brag but I too was close to becoming a best-selling memoir author. Ahhh, 1058 pages of sheer me…oh, sorry, I’m doing it again.",
            "Wow, a new personal best! At this rate, you will be positively swimming in those soda streams! Maybe perhaps I should write a dissertation on the efforts of soda crafting! Think about it, you’d make a really great muse.",
            "You…certainly tried. But not only is this combination and ratio off, I am also now 3 minutes and 45 seconds later than I needed to be. Euler would be so disappointed in me.",
            "Good day to you! Have you read the morning paper? Everyone is talking about your shop, I must say you’re a real chemist in the kitchen. Uhh, one of my students, Rosco, the one with the unorderly appearance and…alternative demeanor, comes here often I see. He showed it to our class. A freshly mixed drink is exactly what I need to celebrate your honor, I will take what I usually have.",
            "Cheers to your success! May your recipes remain calculated and true!",
            "Maybe they should have reconsidered retouching some statements! Ahem, oh, a new recipe by chance? Good to know…",
            "Here you are, my soda barista. How are you doing on this lovely day? It’s test day, my favorite day of the week! Always refreshing seeing students’ works. You know I tried having a discussion with my colleagues on the 90° angles of the new ceilings of our staff building, turns out it was all right, but kept going in tangents if you catch my drift. Say, how about a drink to bring the spirits up and keep the old noggin sharp, hmm?",
            "If you were a student in my class, I would give you extra extra EXTRA credit! The flavors, the aroma, it reminds me of my rainy days while inside reading Chekhov’s ‘Cherry Orchard’. Ah! Such a delight. SHould ever a colleague of mine require a drink, I’ll know exactly where to send them!",
            "Just as chemistry switched from Dalton to Rutherford, so too maybe I must switch gears. It is…adequate, and yet, mildly discouraging all the same."
        };

    public string[] CandiD = new string[]
        {
           "a", "Hi there! How’s it going? Good, good! My day’s been great. I will have the Medium Cheery Float to go please. I’m in a little bit of a rush! Thank you!",
            "Great! Thanks, be sure to follow me!",
            "Uhhh…hehe, no this is great. I love it, don’t sweat it…too much.",
            "Yoohoo! I’m back! Just got done with such an intense workout, so, need to hydrate! Whatcha got for me? Hmmm, I’ll just take the Cheery Float again, that should be easy for you right?!",
            "Ouuu you ARE good! Here, let’s take a selfie! I’ll caption you as the ‘star barista’ of the town, how does that sound? Great, toodles!",
            "Hey, don’t even worry about it, nothing comes easy to everyone right? It’s fine, really. I promise!",
            "Hey! It’s me, your favorite customer! I just had to come back, I followed you on all of your socials by the way, isn’t that fun! You haven’t followed me back yet though…let’s change that when you have time yeah? How about this, how about you make it up to me with my fave? I still want the follows though…hehe!",
            "You remembered! O-M-G, you are the absolute best! You know, I see you around here often, and you’re quick too! What’s your secret? You have to let me in on it, I can share with you all my secrets in return. Well, only the juicy stuff.",
            "Oh, that’s quite alright, I’ll take the follows only, thanks…",
            "Hello hello! Thank you for the follows and your support, always appreciated! Did you see my latest video? Can you believe I did 20 reps in 13 seconds?! That has to be like a new record or something. I have to keep at it, it takes a lot to look and feel great and I don’t wanna slow down any time soon. Say, if you whip me up one of my favorites, maybe I could give you some screen time on my profiles, shout you out a bit you know? I’ll even tag you in it!",
            "Record time! You’re really fast! And 30 drinks in an hour?! Your reps in the gym must be insane. Wait, NO! Don’t tell me you’re just that naturally talented?! I’m totes jelly!",
            "The one drink I’m REALLY gonna have to work off…",
            "Hope business is booming! Can you believe our video got 400k views? People are all the rage about your drinks, and it’s all thanks to me! Say, I could try and hook you up with a sponsorship deal at the gym I frequently go to? They love me, I practically live there! You should come with! Not that you need it but we could totally be like workout BFFS! Sounds great right?! Let’s get some drinks out to celebrate!",
            "Cheers to new friendships and gym workouts and sponsorships!",
            "This…I’ll talk to the owner, maybe give him a small sample size."
        };

    public string[] AveryD = new string[]
    {
       "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
        "Hey there! Just came in for something simple. How about a Large Field’s Favorite?",
        "This looks great, thank you so much, have a good day.",
        "Oh no, this won’t do. Nevermind, it’s fine, I’ll take it. Thanks.",
        "Oh hello again, it’s really nice to see you, so nice seeing the youth hard at work! Can I have the Field’s Favorite please?",
        "Perfect, thanks so much, you’re really good at what you do. Take care!",
        "I don’t mean to impose but I don’t think this is the right drink, sorry!",
        "3 days in a row? Might as well get used to us both. Call me Flutter if you like. That’s what my friends call me anyway.  How do you do it? I could never be in one place for a long time. DO you ever wish you could go somewhere and do something else? Ahhh, when am I not somewhere doing something else? Anyway, I’ll have my usual if you don’t mind.",
        "Mmm, that hits the spot. I’ll have to come here and bottle some up for my next trip. We’re going to the highest heights of the Himalayas!",
        "Hmm, not your best work. Is everything alright? You’re usually so sharp and diligent.",
        "Hi, it’s me Flutter again! I’m so happy you remembered me. I’m here to pick up my usual please. My chicks have me going all over the place today, it’s hectic, but I wouldn’t change it for the world. Just taking a break is all.",
        "Mmm, maybe I should get some back for my chicks. My littlest one is turning 5, and she loves the colors. Oh, my change. Thank you. … Oh, sorry, I like looking through the coins I get to add to my collection. Last month, I found a rare Gaudens double eagle! Cool, right? Oh, I gotta go, bye!",
        "I wouldn’t even feed my kids this. I mean, the sugar, yes the sugar content is just through the roof! I think I’ll just empty this out over here, thanks.",
        "Hey! So guess what? It turns out that you had given me a silver dollar! A. SILVER. Dollar. DO you know how rare those things are?! I have been looking for something like that for YEARS, and you just gave it to me! I must pay you back for your kindness! Hey, how about some drinks, on me? It’s the least I could do for such a great find, my goodness. You go above and beyond!",
        "You are just the best! I will definitely bring my chicks here after school sometimes. I want to cherish this drink for a while here, it will be my last before my plane takes off and I’ll be sky high! Thanks for being the absolute best, I got a new favorite drink, a rare coin and a good friend! See you next week!",
        "Not the best note to leave on but thank you, you tried your best. I’ll be back in a week to see you for more."
    };

}

//StartCoroutine(ShowText());

