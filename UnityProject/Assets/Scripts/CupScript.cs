using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
    }

    public void SizeSmall()
    {
        transform.localScale = new Vector3(0.5f, 0.4f, 0);
    }
    public void SizeMedium()
    {
        transform.localScale = new Vector3(0.5f, 0.8f, 0);
    }
    public void SizeLarge()
    {
        transform.localScale = new Vector3(0.5f, 1.4f, 0);
    }
    public void ResetSize()
    {
        transform.localScale = new Vector3(0.5f, 0.8f, 0);
    }
}
