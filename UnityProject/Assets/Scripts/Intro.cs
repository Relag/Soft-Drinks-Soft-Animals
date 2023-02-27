using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private Text introText;

    private string[] textboxes;
    
    private void Start() {
        //enter textbox text.
    }

    private int TEXTBOXNUM = 3;
    private int currentTextBox = 0;

    public void moveForward() {
        if (currentTextBox < TEXTBOXNUM) {
            currentTextBox++;
            introText.text = textboxes[currentTextBox];
        }
    }

    public void moveBack() {
        if (currentTextBox > 0) {
            currentTextBox--;
            introText.text = textboxes[currentTextBox];
        }
    }
}
