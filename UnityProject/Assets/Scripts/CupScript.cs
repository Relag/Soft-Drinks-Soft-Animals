using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupScript : MonoBehaviour
{

    public GameManager Manager;
    public Text txt;

    bool Instand = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Soda1 = -7.25, 3
    //Soda2 = -5.8, 3
    //Soda3 = -4.45, 3
    // Update is called once per frame
    void Update()
    {
        if (Instand == false)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
        }
        txt.text = (Manager.soda1 + Manager.soda2 + Manager.soda3).ToString() + "%";
    }


    public void SizeSmall()
    {
        transform.localScale = new Vector3(1f, 1f, 0);
    }
    public void SizeMedium()
    {
        transform.localScale = new Vector3(1f, 1.5f, 0);
    }
    public void SizeLarge()
    {
        transform.localScale = new Vector3(1f, 2f, 0);
    }
    public void ResetSize()
    {
        transform.localScale = new Vector3(1f, 1.5f, 0);
    }
    public void SetInstandTrue()
    {
        Instand = true;
    }
    public void SetInstandFalse()
    {
        Instand = false;
    }


}
