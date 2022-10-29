using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonScript : MonoBehaviour
{
    public AudioSource mainMenuBGMusic;
    public AudioSource buttonFX;
    public GameObject settingMenu;


    private void Update()
    {
        SettingsData sd=SettingsManager.LoadSettings();
        mainMenuBGMusic.volume = sd.volumeOfMusic;
        buttonFX.volume = sd.volumeOfSound;
    }
    private void ButtonClickFX() 
    {
        buttonFX.Play();
    }
    public void ButtonStartNewGame() 
    {
        ButtonClickFX();
    }
    public void ButtonContinueGame()
    {
        ButtonClickFX();
        SceneManager.LoadScene(1);
    }
    public void ButtonSetting()
    {
        ButtonClickFX();
        settingMenu.SetActive(true);
    }
    public void ButtonExit() 
    {
        ButtonClickFX();
        Application.Quit();
    }
}
