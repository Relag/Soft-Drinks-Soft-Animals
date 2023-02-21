using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Soda3Script : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public GameManager manager;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }
    int count = 0;
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
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
