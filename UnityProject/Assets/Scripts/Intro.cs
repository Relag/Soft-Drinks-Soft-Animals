using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI introText;

    [SerializeField]
    private MainMenu mainMenu;

    private string[] textboxes;
    private int TEXTBOXNUM = 3;
    private int currentTextBox = 0;
 

    public void moveForward() {
        if (currentTextBox < TEXTBOXNUM) {
            currentTextBox++;
            introText.text = textboxes[currentTextBox];
        }
        else
            mainMenu.StartGame();
    }

    public void moveBack() {
        if (currentTextBox > 0) {
            currentTextBox--;
            introText.text = textboxes[currentTextBox];
        }
    }
}
