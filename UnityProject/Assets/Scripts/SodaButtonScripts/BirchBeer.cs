using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BirchBeer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public GameManager manager;
    public CupScript cup;
    public GameObject Soda;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
        cup.buttonbirchbeer = true;
        Soda.SetActive(true);
    }
    int count = 0;
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
        cup.buttonbirchbeer = false;
        Soda.SetActive(false);
    }

    private void Update()
    {
        if (manager.size != GameManager.cup.none && ((manager.soda1 + manager.soda2 + manager.soda3) < 100))
        {
            if (ispressed && count >= 10)
            {
                manager.soda3 += 1;
                count = 0;
            }
            else
            {
                count += 1;
            }
        }

    }
    // Update is called once per frame
}
