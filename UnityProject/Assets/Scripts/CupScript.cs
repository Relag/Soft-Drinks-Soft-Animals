using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CupScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameManager Manager;
    public Text txt;
    public bool honeyfizz = false;
    public bool ripplecola = false;
    public bool buttonbirchbeer = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool ispressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

    //Soda1 = 175, 7.7
    //Soda2 = 252, 7.7
    //Soda3 = 328, 3
    // Update is called once per frame
    void Update()
    {


        if (honeyfizz == true)
        {
            transform.localPosition = new Vector2(175f, 7.7f);
        }
        else if (ripplecola == true)
        {
            transform.localPosition = new Vector2(252f, 7.7f);
        }
        else if (buttonbirchbeer == true)
        {
            transform.localPosition = new Vector2(328f, 7.7f);
        }
        else
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
        }
        txt.text = (Manager.soda1 + Manager.soda2 + Manager.soda3).ToString() + "%";
    }



    public void HoneyFizz()
    {
        honeyfizz = true;
    }
    public void RippleCola()
    {
        ripplecola = true;
    }
    public void BirchBeer()
    {
        buttonbirchbeer = true;
    }


    public void SizeSmall()
    {
        Manager.size = GameManager.cup.small;
        transform.localScale = new Vector3(1f, 1f);
    }
    public void SizeMedium()
    {
        Manager.size = GameManager.cup.medium;
        transform.localScale = new Vector3(1.25f, 1.25f);
    }
    public void SizeLarge()
    {
        Manager.size = GameManager.cup.large;
        transform.localScale = new Vector3(1.75f, 1.25f);
    }



    public void GoToMouse()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
    }

}
