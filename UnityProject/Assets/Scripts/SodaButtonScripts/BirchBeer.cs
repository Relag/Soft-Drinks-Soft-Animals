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
    public float filled = 0f;
    public float fillRate = 5f;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
        cup.buttonbirchbeer = true;
        Soda.SetActive(true);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
        cup.buttonbirchbeer = false;
        Soda.SetActive(false);
    }

    private void Update()
    {
        if (ispressed)
            if (manager.size != GameManager.cup.none && ((manager.soda1 + manager.soda2 + manager.soda3) < 100))
            {
                filled += fillRate * Time.deltaTime;
                manager.soda3 = (int)filled;
            }
    }
    public void ResetFill()
    {
        filled = 0f;
    }
}
