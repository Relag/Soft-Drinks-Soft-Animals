using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoneyFizz : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public GameManager manager;
    public CupScript cup;
    public GameObject Soda;
    public float fillRate = 5f;
    public float filled = 0f;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
        cup.honeyfizz = true;
        Soda.SetActive(true);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
        cup.honeyfizz = false;
        Soda.SetActive(false);
    }

    private void Update()
    {
        if (ispressed)
            if (manager.size != GameManager.cup.none && ((manager.soda1 + manager.soda2 + manager.soda3) < 100))
            {
                filled += fillRate * Time.deltaTime;
                manager.soda1 = (int)filled;
            }
    }

    public void ResetFill()
    {
        filled = 0f;
    }
}
