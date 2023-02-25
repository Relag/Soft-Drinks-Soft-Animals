using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessOrFail : MonoBehaviour
{

    public GameManager manager;
    // Start is called before the first frame update
    public Image image;


    private void Update()
    {
        if(manager.PassFail == false)
        {
            image.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else
        {
            image.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
    }

}
