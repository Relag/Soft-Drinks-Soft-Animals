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

    private void Start() {
        textboxes[0] = "It’s a bright, clear morning in plush Bermodo City. The sun is shining, the clouds are stuffing-soft, and you are...why are you here again?\n\n...That’s right. Aunt Dora, the old duck, has given you her old soda shop. You don’t really remember her. Your mom certainly didn’t talk about her. But, hey, you’ve always wanted to move to the big city.\n\nAnd if Aunt Dora could do it, how hard can running a soda shop be?";
        introText.text = textboxes[currentTextBox];
    }

 

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
