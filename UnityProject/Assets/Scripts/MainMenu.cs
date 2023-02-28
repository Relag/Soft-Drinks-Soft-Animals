using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject OptionsMenu;

    public void StartGame() {
        SceneManager.LoadScene("GameScene");
        AudioManager.instance.changeSong(1);
    }

}
